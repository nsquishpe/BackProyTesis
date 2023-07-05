using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}
