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
    }
}
