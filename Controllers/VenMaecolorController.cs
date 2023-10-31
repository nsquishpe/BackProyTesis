using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenMaecolorController : ControllerBase
    {
        private Logic_Color _logic;

        public VenMaecolorController(Logic_Color logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<VenMaecolor>> Listar()
        {
            return await _logic.Listar();
        }
    }
}
