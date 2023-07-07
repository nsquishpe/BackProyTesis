using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenMaeclienteController : ControllerBase
    {
        private Logic_Cliente _logic;

        public VenMaeclienteController(Logic_Cliente logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<VenMaecliente>> Listar(string anio)
        {
            return await _logic.Listar(anio);
        }
        [HttpGet("{anio}/{codigo}")]
        public async Task<ActionResult<VenMaecliente>?> BuscarPorId(string anio, string codigo)
        {
            return await _logic.BuscarPorId(anio, codigo);
        }
        [HttpGet("cont/{anio}/{codigo}")]
        public async Task<ActionResult<List<VenMaecliente>>?> BuscarCont(string anio, string codigo)
        {
            return await _logic.BuscarCont(anio, codigo);
        }
    }
}
