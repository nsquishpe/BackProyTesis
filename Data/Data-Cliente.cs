﻿using BackProyTesis.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net.Mail;


namespace BackProyTesis.Data
{
    public class Data_Cliente
    {
        private context _context;
        public Data_Cliente(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<VenMaecliente>> Listar(string anio)
        {
            return await _context.VenMaeclientes.Where(c => c.Anio == anio).ToListAsync();
        }
        public async Task<ActionResult<VenMaecliente>?> BuscarPorId(string anio, string codigo)
        {
            var cli = await _context.VenMaeclientes.FirstOrDefaultAsync(c => c.Anio == anio && c.CliCodigo == codigo);

            if (cli != null)
                return cli;
            else
                return null;
        }
        public async Task<ActionResult<List<VenMaecliente>>?> BuscarCont(string anio, string codigo)
        {
            var clientes = await _context.VenMaeclientes
                .Where(c => c.Anio == anio && c.CliCodigo.Contains(codigo))
                .ToListAsync();

            if (clientes.Count == 0)
                return null;

            return clientes;
        }
        //auxiliar
        private VenMaecliente? BuscaPorCodigo(string cod, string anio)
        {
            var det_invs = _context.VenMaeclientes
                .Where(d => d.CliCodigo == cod && d.Anio == anio)
                .FirstOrDefault();
            return det_invs;
        }
        //CRUD
        public async Task<bool> InsertarCliente(VenMaecliente cli)
        {
            if(BuscaPorCodigo(cli.CliCodigo, cli.Anio) == null)
            {
                _context.VenMaeclientes.Add(cli);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> ActualizarCliente(VenMaecliente cli)
        {
            var clitemp = BuscaPorCodigo(cli.CliCodigo, cli.Anio);
            if (clitemp != null)
            {
                clitemp.Anio = cli.Anio;
                clitemp.CliNombre = cli.CliNombre;
                clitemp.CliDireccion1 = cli.CliDireccion1;
                clitemp.CliTelefono1 = cli.CliTelefono1;
                clitemp.CliCorreo = cli.CliCorreo;
                clitemp.CliNombrec = clitemp.CliNombre.Length > 15 ? clitemp.CliNombre.Substring(0, 15) : clitemp.CliNombre;
                clitemp.CliRucide= clitemp.CliCodigo;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> EliminarCliente(VenMaecliente cli)
        {
            var clitemp = BuscaPorCodigo(cli.CliCodigo, cli.Anio);

            //Verificar que no tenga registros en facturas y ordenes
            Data_Encfac cab_fac = new Data_Encfac(_context);
            Data_CabOrdTrab cab_ord = new Data_CabOrdTrab(_context);

            var resultadoFac = await cab_fac.BuscarPorCli(cli.Anio, cli.CliCodigo);
            var resultadoOrd = await cab_ord.BuscarPorCliCont(cli.Anio, cli.CliCodigo);

            if (clitemp != null)
            {
                if(resultadoFac == null && resultadoOrd == null)
                {
                    _context.VenMaeclientes.Remove(clitemp);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public IEnumerable<ReporteClientesFrecPorAnio> ReporteClientesFrecPorAnio(string anio)
        {
            using (IDbConnection dbConnection = _context.Database.GetDbConnection())
            {
                dbConnection.Open();

                string sqlQuery = @"
            SELECT *
            FROM (
                SELECT VE.ANIO, VE.CLI_CODIGO, VM.CLI_NOMBRE, 
                       COUNT(VE.ENCFAC_NUMERO) AS NUMERO_DE_FACTURAS, 
                       SUM(VE.ENCFAC_TOTAL) AS TOTAL_FACTURAS
                FROM VEN_ENCFAC VE
                JOIN VEN_MAECLIENTE VM ON VE.ANIO = VM.ANIO AND VE.CLI_CODIGO = VM.CLI_CODIGO
                WHERE VE.ANIO = :Anio AND VE.CLI_CODIGO <> '9999999999999'
                GROUP BY VE.ANIO, VE.CLI_CODIGO, VM.CLI_NOMBRE
                HAVING COUNT(VE.ENCFAC_NUMERO) >= 6
                ORDER BY TOTAL_FACTURAS DESC
            )
            WHERE ROWNUM <= 10
            ORDER BY NUMERO_DE_FACTURAS DESC";

                var parametros = new { Anio = anio };

                var resultados = dbConnection.Query<ReporteClientesFrecPorAnio>(sqlQuery, parametros);
                return resultados;
            }
        }

    }
}
