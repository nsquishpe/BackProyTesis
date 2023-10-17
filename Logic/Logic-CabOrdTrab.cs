using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace BackProyTesis.Logic
{
    public class Logic_CabOrdTrab
    {
        private Data_CabOrdTrab _data;

        public Logic_CabOrdTrab(Data_CabOrdTrab data)
        {
            _data = data;
        }
        public async Task<List<CabOrdenTrabajo>> Listar(string anio)
        {
            return await _data.Listar(anio);
        }
        public async Task<string> AsignarNumOrd(string anio)
        {
            return await _data.AsignarNumOrd(anio);
        }
        public async Task<ActionResult<List<CabOrdenTrabajo>>?> BuscarPorCliCont(string anio, string cli)
        {
            return await _data.BuscarPorCliCont(anio, cli);
        }
        public async Task<ActionResult<List<CabOrdenTrabajo>>?> BuscarPorPlacaCont(string anio, string plac)
        {
            return await _data.BuscarPorPlacaCont(anio, plac);
        }
        public async Task<ActionResult<CabOrdenTrabajo>?> BuscarPorNum(string anio, decimal num)
        {
            return await _data.BuscarPorNum(anio, num);
        }
        //CRUD
        public async Task InsertarOrdTrabCab(CabOrdenTrabajo ord)
        {
            await _data.InsertarOrdTrabCab(ord);
        }
        public async Task<bool> ActualizarOrdTrabCab(CabOrdenTrabajo ord)
        {
            return await _data.ActualizarOrdTrabCab(ord);
        }
        public async Task<bool> EliminarOrdTrabCab(CabOrdenTrabajo ord)
        {
            return await _data.EliminarOrdTrabCab(ord);
        }
    }
}
