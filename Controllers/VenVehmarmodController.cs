using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenVehmarmodController : ControllerBase
    {
        private Logic_Marca _logic;

        public VenVehmarmodController(Logic_Marca logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<VenVehmarmod>> Listar()
        {
            return await _logic.Listar();
        }
    }
}
