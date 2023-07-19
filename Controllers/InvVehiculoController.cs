using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvVehiculoController : ControllerBase
    {
        private Logic_InvVeh _logic;

        public InvVehiculoController(Logic_InvVeh logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<InvVehiculo>> Listar()
        {
            return await _logic.Listar();
        }
    }
}
