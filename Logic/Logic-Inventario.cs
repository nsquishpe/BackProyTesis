using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Logic
{
    public class Logic_Inventario
    {
        private Data_Inventario _data;

        public Logic_Inventario(Data_Inventario data)
        {
            _data = data;
        }
        public async Task<ActionResult<List<InvTrnkardex>>?> ListarEntradas(string anio, string cod)
        {
            return await _data.ListarEntradas(anio, cod);
        }
        public async Task<ActionResult<List<InvTrnkardex>>?> ListarSalidas(string anio, string cod)
        {
            return await _data.ListarSalidas(anio, cod);
        }
        public async Task<string> ObtenerStock(string anio, string cod)
        {
            return await _data.ObtenerStock(anio, cod);
        }
        public async Task<string> ObtenerCostoCompra(string anio, string cod)
        {
            return await _data.ObtenerCostoCompra(anio, cod);
        }
        public async Task<string> ObtenerCostoVenta(string anio, string cod)
        {
            return await _data.ObtenerCostoVenta(anio, cod);
        }
    }
}
