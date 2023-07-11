using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_GrupoRep
    {
        private context _context;
        public Data_GrupoRep(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<InvMaegrupo>> Listar(string anio)
        {
            return await _context.InvMaegrupos.Where(c => c.Anio == anio).ToListAsync();
        }
    }
}
