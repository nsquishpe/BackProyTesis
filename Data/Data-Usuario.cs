using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_Usuario
    {
        private context _context;
        public Data_Usuario(context contexto)
        {
            _context = contexto;
        }
        public async Task<bool> TraerUsuario(string usuIdentificacion, string usuClave)
        {
            // Obtener el usuario que coincida con las credenciales y la fecha de vencimiento vigente.
            var usuario = await _context.SegMaeusuarios
                .FirstOrDefaultAsync(u => u.Usuidentificacion == usuIdentificacion && u.Usuclave == usuClave 
                && u.Usufechafinal >= DateTime.Today);
            if(usuario != null) {
                return true;
            }
            return false;
        }
    }
}
