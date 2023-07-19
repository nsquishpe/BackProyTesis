using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetOrdServicioController : ControllerBase
    {
        private Logic_DetOrdSer _logic;

        public DetOrdServicioController(Logic_DetOrdSer logic)
        {
            _logic = logic;
        }
        [HttpGet("det/{num}/{anio}")]
        public async Task<List<DetOrdServicio>?> TraerDetSer(decimal num, string anio)
        {
            return await _logic.TraerDetSer(num, anio);
        }
        //CRUD
        [HttpPost]
        public async Task InsertarDetallesServ(decimal num, string anio, List<Servicio> ser)
        {
            await _logic.InsertarDetallesServ(num, anio, ser);
        }
    }
}
