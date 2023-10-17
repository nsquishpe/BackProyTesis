using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabOrdenTrabajoController : ControllerBase
    {
        private Logic_CabOrdTrab _logic;

        public CabOrdenTrabajoController(Logic_CabOrdTrab logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<CabOrdenTrabajo>> Listar(string anio)
        {
            return await _logic.Listar(anio);
        }
        [HttpGet("cli/{anio}/{cli}")]
        public async Task<ActionResult<List<CabOrdenTrabajo>>?> BuscarPorCliCont(string anio, string cli)
        {
            return await _logic.BuscarPorCliCont(anio, cli);
        }
        [HttpGet("plac/{anio}/{plac}")]
        public async Task<ActionResult<List<CabOrdenTrabajo>>?> BuscarPorPlacaCont(string anio, string plac)
        {
            return await _logic.BuscarPorPlacaCont(anio, plac);
        }
        [HttpGet("num/{anio}/{num}")]
        public async Task<ActionResult<CabOrdenTrabajo>?> BuscarPorNum(string anio, decimal num)
        {
            return await _logic.BuscarPorNum(anio, num);
        }
        //CRUD
        [HttpPost]
        public async Task InsertarOrdTrabCab(CabOrdenTrabajo ord)
        {
            await _logic.InsertarOrdTrabCab(ord);
        }
        [HttpPut]
        public async Task<bool> ActualizarOrdTrabCab(CabOrdenTrabajo ord)
        {
            return await _logic.ActualizarOrdTrabCab(ord);
        }
        [HttpDelete]
        public async Task<bool> EliminarOrdTrabCab(CabOrdenTrabajo ord)
        {
            return await _logic.EliminarOrdTrabCab(ord);
        }
    }
}
