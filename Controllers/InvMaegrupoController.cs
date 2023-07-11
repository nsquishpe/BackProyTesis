using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvMaegrupoController : ControllerBase
    {
        private Logic_GrupoRep _logic;

        public InvMaegrupoController(Logic_GrupoRep logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<InvMaegrupo>> Listar(string anio)
        {
            return await _logic.Listar(anio);
        }
    }
}
