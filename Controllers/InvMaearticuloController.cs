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
        public async Task<ActionResult<List<InvMaearticulo>>?> BuscarPorCod(string anio, string cod)
        {
            return await _logic.BuscarPorCod(anio, cod);
        }
    }
}
