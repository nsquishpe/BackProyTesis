using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetOrdInventarioController : ControllerBase
    {
        private Logic_DetOrdInv _logic;

        public DetOrdInventarioController(Logic_DetOrdInv logic)
        {
            _logic = logic;
        }
        [HttpGet("det/{num}/{anio}")]
        public async Task<List<DetOrdInventario>?> TraerDetInv(decimal num, string anio)
        {
            return await _logic.TraerDetInv(num, anio);
        }
        //CRUD
        [HttpPost]
        public async Task<bool> InsertarDetallesInv(decimal num, List<DetOrdInventario> inv)
        {
           return await _logic.InsertarDetallesInv(num, inv);
        }
        [HttpPut]
        public async Task<bool> ActualizarCliente(decimal num, List<DetOrdInventario> inv)
        {
            return await _logic.ActualizarDetInvs(num, inv);
        }
        [HttpDelete]
        public async Task<bool> EliminarDetInvs(decimal num, string anio)
        {
            return await _logic.EliminarDetInvs(num, anio);
        }
    }
}
