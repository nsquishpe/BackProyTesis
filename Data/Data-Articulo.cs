using BackProyTesis.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BackProyTesis.Data
{
    public class Data_Articulo
    {
        private context _context;
        public Data_Articulo(context contexto)
        {
            _context = contexto;
        }
        public async Task<ActionResult<List<InvMaearticulo>>?> ListarPorGrupo(string anio, string cod)
        {
            var arts = await _context.InvMaearticulos
                .Where(c => (c.Anio == anio) && (c.GrupCodigo == cod))
                .ToListAsync();

            if (arts.Count == 0)
                return null;

            return arts;
        }
        //REPORTES
        public IEnumerable<ReporteArticulos> ReporteGeneral(string anio, string bodega, string fecha)
        {
            try
            {
                using (IDbConnection dbConnection = _context.Database.GetDbConnection())
                {
                    dbConnection.Open();

                    string sqlQuery = @"
                        SELECT ANIO, 
                               ART_CODIGO, 
                               ART_NOMBRE, 
                               INV_FNC_OBTIENEEXISTENXART(ANIO, :Bodega, :Fecha, ART_CODIGO) AS EXISTENCIA, 
                               INV_FNC_OBTIENE_NOMBREGRUPO(grup_codigo, ANIO) AS GRUPO, 
                               COALESCE(ART_PRECIOSIVA, 0) AS ART_PRECIOSIVA, 
                               COALESCE(ART_PRECIOCIVA, 0) AS ART_PRECIOCIVA 
                        FROM INV_MAEARTICULO
                        WHERE ANIO = :Anio
                        AND INV_FNC_OBTIENEEXISTENXART(ANIO, :Bodega, :Fecha, ART_CODIGO) > 0
                        ORDER BY INV_FNC_OBTIENE_NOMBREGRUPO(grup_codigo, ANIO), art_nombre";

                    var parametros = new { Anio = anio, Bodega = bodega, Fecha = fecha };

                    var resultados = dbConnection.Query<ReporteArticulos>(sqlQuery, parametros);
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

        public IEnumerable<ReporteArticulos> ReportePorGrupo(string anio, string bodega, string fecha, string grup)
        {
            using (IDbConnection dbConnection = _context.Database.GetDbConnection())
            {
                dbConnection.Open();

                string sqlQuery = @"
            SELECT ANIO, ART_CODIGO, ART_NOMBRE, 
                   INV_FNC_OBTIENEEXISTENXART(ANIO, :Bodega, :Fecha, ART_CODIGO) AS EXISTENCIA, 
                   INV_FNC_OBTIENE_NOMBREGRUPO(grup_codigo, ANIO) AS GRUPO, 
                   ART_PRECIOSIVA, ART_PRECIOCIVA
            FROM INV_MAEARTICULO
            WHERE ANIO = :Anio
            AND grup_codigo = :Grup
            AND INV_FNC_OBTIENEEXISTENXART(ANIO, :Bodega, :Fecha, ART_CODIGO) > 0
            ORDER BY INV_FNC_OBTIENE_NOMBREGRUPO(grup_codigo, ANIO), ART_NOMBRE";

                var parametros = new { Anio = anio, Bodega = bodega, Fecha = fecha, Grup = grup };

                var resultados = dbConnection.Query<ReporteArticulos>(sqlQuery, parametros);
                return resultados;
            }
        }



    }
}
