﻿using BackProyTesis.Data;
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
    }
}