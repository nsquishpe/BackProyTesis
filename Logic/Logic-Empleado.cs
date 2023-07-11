using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackProyTesis.Logic
{
    public class Logic_Empleado
    {
        private Data_Empleado _data;

        public Logic_Empleado(Data_Empleado data)
        {
            _data = data;
        }
        public async Task<List<NomEmpleado>> Listar(string anio)
        {
            return await _data.Listar(anio);
        }
        public async Task<ActionResult<NomEmpleado>?> BuscarPorAlias(string anio, string alias)
        {
            return await _data.BuscarPorAlias(anio, alias);
        }
    }
}
