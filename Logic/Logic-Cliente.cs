using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace BackProyTesis.Logic
{
    public class Logic_Cliente
    {
        private Data_Cliente _data;

        public Logic_Cliente(Data_Cliente data)
        {
            _data = data;
        }
        public async Task<List<VenMaecliente>> Listar(string anio)
        {
            return await _data.Listar(anio);
        }
        public async Task<ActionResult<VenMaecliente>?> BuscarPorId(string anio, string codigo)
        {
            return await _data.BuscarPorId(anio, codigo);
        }
        public async Task<ActionResult<List<VenMaecliente>>?> BuscarCont(string anio, string codigo)
        {
            return await _data.BuscarCont(anio, codigo); 
        }
        //CRUD
        public async Task<bool> InsertarCliente(VenMaecliente cli)
        {
            return await _data.InsertarCliente(cli);
        }
        public async Task<bool> ActualizarCliente(VenMaecliente cli)
        {
            return await _data.ActualizarCliente(cli);
        }
        public async Task<bool> EliminarCliente(VenMaecliente cli)
        {
            return await _data.EliminarCliente(cli);
        }
    }
}
