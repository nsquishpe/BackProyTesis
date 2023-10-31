using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_Colores
    {
        private context _context;
        public Data_Colores(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<VenMaecolor>> Listar()
        {
            return await _context.VenMaecolors.ToListAsync();
        }
    }
}
