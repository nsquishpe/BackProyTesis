using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomEmpleadoController : ControllerBase
    {
        private Logic_Empleado _logic;

        public NomEmpleadoController(Logic_Empleado logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<NomEmpleado>> Listar(string anio)
        {
            return await _logic.Listar(anio);
        }
        [HttpGet("{anio}/{alias}")]
        public async Task<ActionResult<NomEmpleado>?> BuscarPorAlias(string anio, string alias)
        {
            return await _logic.BuscarPorAlias(anio, alias);
        }
    }
}
