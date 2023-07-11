using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_Empleado
    {
        private context _context;
        public Data_Empleado(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<NomEmpleado>> Listar(string anio)
        {
            return await _context.NomEmpleados.Where(c => c.Anio == anio).ToListAsync();
        }
        public async Task<ActionResult<NomEmpleado>?> BuscarPorAlias(string anio, string alias)
        {
            var emp = await _context.NomEmpleados.FirstOrDefaultAsync(c => c.Anio == anio && c.EmpAlias == alias);

            if (emp != null)
                return emp;
            else
                return null;
        }
    }
}
