using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_Detfac
    {
        private context _context;
        public Data_Detfac(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<VenDetfac>> TraerDetFac(string anio, string num)
        {
            var detalleFactura = await _context.VenDetfacs
                .Where(d => d.EncfacNumero == num && d.Anio == anio)
                .OrderBy(d => d.DetfacOrden)
                .ToListAsync();

            return detalleFactura;
        }
    }
}
