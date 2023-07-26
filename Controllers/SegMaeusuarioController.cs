using BackProyTesis.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegMaeusuarioController : ControllerBase
    {
        private Logic_Usuario _logic;

        public SegMaeusuarioController (Logic_Usuario logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<bool> TraerUsuario(string usu, string clave)
        {
            return await _logic.TraerUsuario(usu, clave);
        }
    }
}
