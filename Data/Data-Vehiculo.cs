using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Data;
using Dapper;

namespace BackProyTesis.Data
{
    public class Data_Vehiculo
    {
        private context _context;
        public Data_Vehiculo(context contexto)
        {
            _context = contexto;
        }
        public async Task<ActionResult<VenVhcspcf>?> BuscarPorPlacFac(string anio, string plac, string nfac)
        {
            var fac = await _context.VenVhcspcfs.FirstOrDefaultAsync(c => c.Anio == anio && c.EncfacNumero == nfac && c.VhcspcfPlaca == plac);

            if (fac != null)
                return fac;
            else
                return null;
        }
        public async Task<ActionResult<VenVhcspcf>?> BuscarPorFac(string anio, string nfac)
        {
            var fac = await _context.VenVhcspcfs.FirstOrDefaultAsync(c => c.Anio == anio && c.EncfacNumero == nfac);

            if (fac != null)
                return fac;
            else
                return null;
        }
        public async Task<List<string>> AutosPorAnio(string anio)
        {
            var placas = await _context.VenVhcspcfs
                                      .Where(v => v.Anio == anio)
                                      .Select(v => v.VhcspcfPlaca)
                                      .Distinct()
                                      .ToListAsync();

            return placas!;
        }
        public async Task<Dictionary<string, int>> AutosPorMarca(string anio)
        {
            var conteoMarcas = await _context.VenVhcspcfs
                .Where(v => v.Anio == anio && !string.IsNullOrEmpty(v.VhcspcfMarcaDescrip))
                .GroupBy(v => v.VhcspcfMarcaDescrip)
                .ToDictionaryAsync(g => g.Key ?? string.Empty, g => g.Select(v => v.VhcspcfPlaca).Distinct().Count());

            return conteoMarcas!;
        }
        public async Task<List<VenVhcspcf>?> BuscarPorCli(string anio, string cli)
        {
            var vehiculosRegistrados = await (
                from fac in _context.VenEncfacs
                join vehiculo in _context.VenVhcspcfs on fac.EncfacNumero equals vehiculo.EncfacNumero
                where fac.CliCodigo == cli && fac.Anio == anio && vehiculo.Anio == anio
                group vehiculo by vehiculo.VhcspcfPlaca into grupo
                select grupo.First()
            ).ToListAsync();

            return vehiculosRegistrados;
        }
        //REPORTES
        public IEnumerable<ReporteRankMarca> ReporteRankMarcas(string anio)
        {
            using (IDbConnection dbConnection = _context.Database.GetDbConnection())
            {
                dbConnection.Open();

                string sqlQuery = @"
                SELECT *
                FROM (
                    SELECT 
                        CASE 
                            WHEN INSTR(v.VHCSPCF_MARCA_DESCRIP, 'CHEVROLET') > 0 THEN 'CHEVROLET'
                            ELSE v.VHCSPCF_MARCA_DESCRIP 
                        END AS Marca,
                        COUNT(DISTINCT v.VHCSPCF_PLACA) AS CantidadVehiculosConMarca
                    FROM VEN_VHCSPCF v
                    JOIN VEN_ENCFAC e ON e.ENCFAC_NUMERO = v.ENCFAC_NUMERO 
                                        AND e.COM_CODIGO = v.COM_CODIGO 
                                        AND e.ANIO = v.ANIO
                    WHERE e.ANIO = :Anio
                    GROUP BY 
                        CASE 
                            WHEN INSTR(v.VHCSPCF_MARCA_DESCRIP, 'CHEVROLET') > 0 THEN 'CHEVROLET'
                            ELSE v.VHCSPCF_MARCA_DESCRIP 
                        END
                    ORDER BY CantidadVehiculosConMarca DESC
                )
                WHERE ROWNUM <= 10";

                var parametros = new { Anio = anio };

                var resultados = dbConnection.Query<ReporteRankMarca>(sqlQuery, parametros);
                return resultados;
            }
        }
    }
}
