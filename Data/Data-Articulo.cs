using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_Articulo
    {
        private context _context;
        public Data_Articulo(context contexto)
        {
            _context = contexto;
        }
        public async Task<ActionResult<List<InvMaearticulo>>?> ListarPorGrupo(string anio, string cod)
        {
            var arts = await _context.InvMaearticulos
                .Where(c => (c.Anio == anio) && (c.GrupCodigo == cod))
                .ToListAsync();

            if (arts.Count == 0)
                return null;

            return arts;
        }
    }
}
