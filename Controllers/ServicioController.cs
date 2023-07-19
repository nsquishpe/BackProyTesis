using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private Logic_Servicios _logic;

        public ServicioController(Logic_Servicios logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<Servicio>> Listar()
        {
            return await _logic.Listar();
        }
    }
}
