using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_Servicios
    {
        private context _context;
        public Data_Servicios(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<Servicio>> Listar()
        {
            return await _context.Servicios.ToListAsync();
        }
    }
}
