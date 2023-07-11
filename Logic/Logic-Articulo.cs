using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackProyTesis.Logic
{
    public class Logic_Articulo
    {
        private Data_Articulo _data;

        public Logic_Articulo(Data_Articulo data)
        {
            _data = data;
        }
        public async Task<ActionResult<List<InvMaearticulo>>?> BuscarPorCod(string anio, string cod)
        {
            return await _data.BuscarPorCod(anio, cod);
        }
    }
}
