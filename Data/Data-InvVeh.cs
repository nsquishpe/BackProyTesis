using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_InvVeh
    {
        private context _context;
        public Data_InvVeh(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<InvVehiculo>> Listar()
        {
            return await _context.InvVehiculos.ToListAsync();
        }
    }
}
