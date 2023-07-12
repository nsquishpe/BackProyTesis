using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvTrnkardexController : ControllerBase
    {
        private Logic_Inventario  _logic;

        public InvTrnkardexController(Logic_Inventario logic)
        {
            _logic = logic;
        }
        [HttpGet("en/{anio}/{cod}")]
        public async Task<ActionResult<List<InvTrnkardex>>?> ListarEntradas(string anio, string cod)
        {
            return await _logic.ListarEntradas(anio, cod);
        }
        [HttpGet("sa/{anio}/{cod}")]
        public async Task<ActionResult<List<InvTrnkardex>>?> ListarSalidas(string anio, string cod)
        {
            return await _logic.ListarSalidas(anio, cod);
        }
        [HttpGet("stock/{anio}/{cod}")]
        public async Task<string> ObtenerStock(string anio, string cod)
        {
            return await _logic.ObtenerStock(anio, cod);
        }
        [HttpGet("com/{anio}/{cod}")]
        public async Task<string> ObtenerCostoCompra(string anio, string cod)
        {
            return await _logic.ObtenerCostoCompra(anio, cod);
        }
    }
}
