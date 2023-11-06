using BackProyTesis.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

namespace BackProyTesis.Data
{
    public class Data_Encfac
    {
        private context _context;
        public Data_Encfac(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<VenEncfac>> Listar(string anio)
        {
            return await _context.VenEncfacs.Where(c => c.Anio == anio).ToListAsync();
        }
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorCli(string anio, string cli)
        {
            var facs = await _context.VenEncfacs
                .Where(c => (c.Anio == anio) && (c.CliCodigo == cli))
                .ToListAsync();

            if (facs.Count == 0)
                return null;

            return facs;
        }
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorCliCont(string anio, string cli)
        {
            var facs = await _context.VenEncfacs
                .Where(c => c.Anio == anio && c.CliCodigo.Contains(cli))
                .ToListAsync();

            if (facs.Count == 0)
                return null;

            return facs;
        }
        public async Task<ActionResult<VenEncfac>?> BuscarPorNum(string anio, string num)
        {
            var fac = await _context.VenEncfacs.FirstOrDefaultAsync(c => c.Anio == anio && c.EncfacNumero == num);

            if (fac != null)
                return fac;
            else
                return null;
        }
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorNumCont(string anio, string num)
        {
            var facs = await _context.VenEncfacs
                .Where(c => c.Anio == anio && c.EncfacNumero.Contains(num))
                .ToListAsync();

            if (facs.Count == 0)
                return null;

            return facs;
        }
        public async Task<List<VenEncfac>?> BuscarPorPlaca(string anio, string placa)
        {
            var facs = await _context.VenEncfacs
                .Join(_context.VenVhcspcfs,
                      encfac => new NewRecord(encfac.EncfacNumero, encfac.Anio),
                      vhcspcf => new NewRecord(vhcspcf.EncfacNumero, vhcspcf.Anio),
                      (encfac, vhcspcf) => new { encfac, vhcspcf })
                .Where(x => x.vhcspcf.VhcspcfPlaca == placa && x.encfac.Anio == anio)
                .Select(x => x.encfac)
                .ToListAsync();

            if (facs.Count == 0)
                return null;

            return facs;
        }

        public async Task<List<VenEncfac>?> BuscarPorPlacaCont(string anio, string placa)
        {
            var facs = await _context.VenEncfacs
                .Join(_context.VenVhcspcfs,
                      encfac => new NewRecord(encfac.EncfacNumero, encfac.Anio),
                      vhcspcf => new NewRecord(vhcspcf.EncfacNumero, vhcspcf.Anio),
                      (encfac, vhcspcf) => new { encfac, vhcspcf })
                .Where(x => x.encfac.Anio == anio && x.vhcspcf.VhcspcfPlaca.Contains(placa))
                .Select(x => x.encfac)
                .ToListAsync();

            if (facs.Count == 0)
                return null;

            return facs;
        }
        //MANEJO GARANTÍA
        public async Task<bool> ActualizarPorGarantia(VenEncfac fac)
        {
            var fac_temp = BuscaPorCodigo(fac.EncfacNumero, fac.Anio);
            if (fac_temp != null)
            {
                fac_temp.EncfacGarantia = fac.EncfacGarantia;
                fac_temp.EncfacObsgarantia = fac.EncfacObsgarantia;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        //auxiliar
        private VenEncfac? BuscaPorCodigo(string cod, string anio)
        {
            var fac = _context.VenEncfacs
                .Where(d => d.EncfacNumero == cod && d.Anio == anio)
                .FirstOrDefault();
            return fac;
        }
        //REPORTES
        public IEnumerable<ReporteVentas> ReporteGeneral(string fechaInicio, string fechaFin)
        {
            try
            {
                using (IDbConnection dbConnection = _context.Database.GetDbConnection())
                {
                    dbConnection.Open();

                    string sqlQuery = @"
                    SELECT CLI_CODIGO, 
                           CLI_NOMBRE, 
                           TO_DATE(TO_CHAR(ENCFAC_FECHAEMISION, 'dd/mm/yyyy'), 'dd/mm/yyyy') AS ENCFAC_FECHAEMISION, 
                           ENCFAC_ESTADO, 
                           ENCFAC_REFERENCIA, 
                           NVL(encfac_basecero, 0) + NVL(encfac_baseiva, 0) AS SUBTOTAL, 
                           encfac_valoriva AS IVA, 
                           encfac_total AS TOTAL 
                    FROM ven_encfac 
                    WHERE TO_DATE(TO_CHAR(ENCFAC_FECHAEMISION, 'dd/mm/yyyy'), 'dd/mm/yyyy') BETWEEN 
                        TO_DATE(:FechaInicio, 'dd/mm/yyyy') AND TO_DATE(:FechaFin, 'dd/mm/yyyy')";

                    var parametros = new { FechaInicio = fechaInicio, FechaFin = fechaFin };

                    var resultados = dbConnection.Query<ReporteVentas>(sqlQuery, parametros);
                    return resultados;
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción: registrar el mensaje de error para diagnóstico
                Console.WriteLine($"Error: {ex.Message}");

                // Puedes lanzar la excepción nuevamente para interrumpir el flujo si es necesario
                throw;
            }
        }
        public IEnumerable<ReporteVentas> ReportePorCliente(string fechaInicio, string fechaFin, string clienteCodigo)
        {
            try
            {
                using (IDbConnection dbConnection = _context.Database.GetDbConnection())
                {
                    dbConnection.Open();

                    string sqlQuery = @"
                    SELECT CLI_CODIGO, 
                           CLI_NOMBRE, 
                           TO_DATE(TO_CHAR(ENCFAC_FECHAEMISION, 'dd/mm/yyyy'), 'dd/mm/yyyy') AS ENCFAC_FECHAEMISION, 
                           ENCFAC_ESTADO, 
                           ENCFAC_REFERENCIA, 
                           NVL(encfac_basecero, 0) + NVL(encfac_baseiva, 0) AS SUBTOTAL, 
                           encfac_valoriva AS IVA, 
                           encfac_total AS TOTAL 
                    FROM ven_encfac 
                    WHERE cli_codigo = :ClienteCodigo 
                    AND TO_DATE(TO_CHAR(ENCFAC_FECHAEMISION, 'dd/mm/yyyy'), 'dd/mm/yyyy') BETWEEN 
                        TO_DATE(:FechaInicio, 'dd/mm/yyyy') AND TO_DATE(:FechaFin, 'dd/mm/yyyy')";

                    var parametros = new
                    {
                        FechaInicio = fechaInicio,
                        FechaFin = fechaFin,
                        ClienteCodigo = clienteCodigo
                    };

                    var resultados = dbConnection.Query<ReporteVentas>(sqlQuery, parametros);
                    return resultados;
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción: registrar el mensaje de error para diagnóstico
                Console.WriteLine($"Error: {ex.Message}");

                // Puedes lanzar la excepción nuevamente para interrumpir el flujo si es necesario
                throw;
            }
        }
    }

    internal record NewRecord(string? EncfacNumero, string Anio);
}
