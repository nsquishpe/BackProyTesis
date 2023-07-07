using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenEncfacController : ControllerBase
    {
        private Logic_Encfac _logic;

        public VenEncfacController(Logic_Encfac logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public async Task<List<VenEncfac>> Listar(string anio)
        {
            return await _logic.Listar(anio);
        }
        [HttpGet("{anio}/{cli}")]
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorCli(string anio, string cli)
        {
            return await _logic.BuscarPorCli(anio, cli);
        }
        [HttpGet("num/{anio}/{num}")]
        public async Task<ActionResult<VenEncfac>?> BuscarPorNum(string anio, string num)
        {
            return await _logic.BuscarPorNum(anio, num);
        }
        [HttpGet("cont/{anio}/{num}")]
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorNumCont(string anio, string num)
        {
            return await _logic.BuscarPorNumCont(anio, num);
        }
        [HttpGet("plac/{anio}/{placa}")]
        public async Task<List<VenEncfac>?> BuscarPorPlaca(string anio, string placa)
        {
            return await _logic.BuscarPorPlaca(anio, placa);
        }
    }
}
