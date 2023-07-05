using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
