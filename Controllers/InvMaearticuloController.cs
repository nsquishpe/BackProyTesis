using BackProyTesis.Data;
using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvMaearticuloController : ControllerBase
    {
        private Logic_Articulo _logic;

        public InvMaearticuloController(Logic_Articulo logic)
        {
            _logic = logic;
        }
        [HttpGet("{anio}/{cod}")]
        public async Task<ActionResult<List<InvMaearticulo>>?> ListarPorGrupo(string anio, string cod)
        {
            return await _logic.ListarPorGrupo(anio, cod);
        }
        //REPORTE
        [HttpGet("ReporteGeneral")]
        public IActionResult ReporteGeneral(string anio, string bodega, string fecha)
        {
            try
            {
                var resultados = _logic.ReporteGeneral(anio, bodega, fecha);

                if (resultados == null || !resultados.Any())
                {
                    return NotFound("No se encontraron resultados para los parámetros proporcionados.");
                }

                return Ok(resultados);
            }
            catch (Exception ex)
            {
                // Loguear el error
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        [HttpGet("ReportePorGrupo")]
        public IActionResult ReportePorGrupo(string anio, string bodega, string fecha, string grup)
        {
            try
            {
                var resultados = _logic.ReportePorGrupo(anio, bodega, fecha, grup);

                if (resultados == null || !resultados.Any())
                {
                    return NotFound("No se encontraron resultados para los parámetros proporcionados.");
                }

                return Ok(resultados);
            }
            catch (Exception ex)
            {
                // Loguear el error
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

    }
}
