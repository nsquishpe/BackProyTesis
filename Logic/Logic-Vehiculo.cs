using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Logic
{
    public class Logic_Vehiculo
    {
        private Data_Vehiculo _data;

        public Logic_Vehiculo(Data_Vehiculo data)
        {
            _data = data;
        }
        public async Task<ActionResult<VenVhcspcf>?> BuscarPorPlacFac(string anio, string plac, string nfac)
        {
            return await _data.BuscarPorPlacFac(anio, plac, nfac);
        }
        public async Task<ActionResult<List<string>>> AutosPorAnio(string anio)
        {
            return await _data.AutosPorAnio(anio);
        }
        public async Task<Dictionary<string, int>> AutosPorMarca(string anio)
        {
            return await _data.AutosPorMarca(anio);
        }
        public async Task<List<VenVhcspcf>?> BuscarPorCli(string anio, string cli)
        {
            return await _data.BuscarPorCli(anio,cli);
        }
    }
}
