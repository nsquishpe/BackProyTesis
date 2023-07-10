using BackProyTesis.Logic;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BackProyTesis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenDetfacController : ControllerBase
    {
        private Logic_Detfac _logic;

        public VenDetfacController(Logic_Detfac logic)
        {
            _logic = logic;
        }
        [HttpGet("{anio}/{num}")]
        public async Task<List<VenDetfac>> TraerDetFac(string anio, string num)
        {
            return await _logic.TraerDetFac(anio, num);
        }
    }
}
