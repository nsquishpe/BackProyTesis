using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;


namespace BackProyTesis.Data
{
    public class Data_Cliente
    {
        private context _context;
        public Data_Cliente(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<VenMaecliente>> Listar(string anio)
        {
            return await _context.VenMaeclientes.Where(c => c.Anio == anio).ToListAsync();
        }
        public async Task<ActionResult<VenMaecliente>?> BuscarPorId(string anio, string codigo)
        {
            var cli = await _context.VenMaeclientes.FirstOrDefaultAsync(c => c.Anio == anio && c.CliCodigo == codigo);

            if (cli != null)
                return cli;
            else
                return null;
        }
    }
}
