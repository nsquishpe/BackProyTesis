using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;

namespace BackProyTesis.Logic
{
    public class Logic_Encfac
    {
        private Data_Encfac _data;

        public Logic_Encfac(Data_Encfac data)
        {
            _data = data;
        }
        public async Task<List<VenEncfac>> Listar(string anio)
        {
            return await _data.Listar(anio);
        }
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorCli(string anio, string cli)
        {
            return await _data.BuscarPorCli(anio, cli);
        }
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorCliCont(string anio, string cli)
        {
            return await _data.BuscarPorCliCont(anio, cli);
        }
        public async Task<ActionResult<VenEncfac>?> BuscarPorNum(string anio, string num)
        {
            return await _data.BuscarPorNum(anio, num);
        }
        public async Task<ActionResult<List<VenEncfac>>?> BuscarPorNumCont(string anio, string num)
        {
            return await _data.BuscarPorNumCont(anio, num);
        }
        public async Task<List<VenEncfac>?> BuscarPorPlaca(string anio, string placa)
        {
            return await _data.BuscarPorPlaca(anio, placa);
        }
        public async Task<List<VenEncfac>?> BuscarPorPlacaCont(string anio, string placa)
        {
            return await _data.BuscarPorPlacaCont(anio, placa);
        }
        public async Task<bool> ActualizarPorGarantia(VenEncfac fac)
        {
            return await _data.ActualizarPorGarantia(fac);
        }
    }
}
