using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenVhcspcfController : ControllerBase
    {
        private Logic_Vehiculo _logic;

        public VenVhcspcfController(Logic_Vehiculo logic)
        {
            _logic = logic;
        }
        [HttpGet("fac/{anio}/{nfac}")]
        public async Task<ActionResult<VenVhcspcf>?> BuscarPorFac(string anio, string nfac)
        {
            return await _logic.BuscarPorFac(anio, nfac);
        }
        [HttpGet("{anio}/{plac}/{nfac}")]
        public async Task<ActionResult<VenVhcspcf>?> BuscarPorPlacFac(string anio, string plac, string nfac)
        {
            return await _logic.BuscarPorPlacFac(anio, plac, nfac);
        }
        [HttpGet]
        public async Task<ActionResult<List<string>>> AutosPorAnio(string anio)
        {
            return await _logic.AutosPorAnio(anio);
        }
        [HttpGet("marc/{anio}")]
        public async Task<Dictionary<string, int>> AutosPorMarca(string anio)
        {
            return await _logic.AutosPorMarca(anio);
        }
        [HttpGet("cli/{anio}/{cli}")]
        public async Task<List<VenVhcspcf>?> BuscarPorCli(string anio, string cli)
        {
            return await _logic.BuscarPorCli(anio, cli);
        }
        [HttpGet("ReporteRankMarcas")]
        public IActionResult ReporteRankMarcas(string anio)
        {
            try
            {
                var resultados = _logic.ReporteRankMarcas(anio);

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
