using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace BackProyTesis.Data
{
    public class Data_Marcas
    {
        private context _context;
        public Data_Marcas(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<VenVehmarmod>> Listar()
        {
            var registros = await _context.VenVehmarmods.ToListAsync();

            var registrosres = registros
            .Where(registro => !(registro.VehmarmodNombre ?? "")
                                .Contains("CHEVROLET", StringComparison.OrdinalIgnoreCase))
            .ToList();
            var registroChevrolet = registros
            .FirstOrDefault(registro =>
                (registro.VehmarmodNombre ?? "").Equals("CHEVROLET", StringComparison.OrdinalIgnoreCase));
            if(registroChevrolet != null )
            {
                registrosres.Add(registroChevrolet);
            }
            return registrosres;
        }
    }
}
