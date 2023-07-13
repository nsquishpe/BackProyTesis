using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_Inventario
    {
        private context _context;
        public Data_Inventario(context contexto)
        {
            _context = contexto;
        }
        public async Task<ActionResult<List<InvTrnkardex>>?> ListarEntradas(string anio, string cod)
        {
            var inv = await _context.InvTrnkardices
                 .Where(c => (c.Anio == anio) && (c.ArtCodigo == cod) && (c.TrnartTipo == "EN"))
                 .OrderBy(c => c.TrnartFechaes)
                 .ToListAsync();

            if (inv.Count == 0)
                return null;

            return inv;
        }
        public async Task<ActionResult<List<InvTrnkardex>>?> ListarSalidas(string anio, string cod)
        {
            var inv = await _context.InvTrnkardices
                .Where(c => (c.Anio == anio) && (c.ArtCodigo == cod) && (c.TrnartTipo == "SA"))
                 .OrderBy(c => c.TrnartFechaes)
                 .ToListAsync();

            if (inv.Count == 0)
                return null;

            return inv;
        }
        public async Task<string> ObtenerStock(string anio, string cod)
        {
            int entradas = (int)await _context.InvTrnkardices
             .Where(c => c.Anio == anio && c.ArtCodigo == cod && c.TrnartTipo == "EN")
             .SumAsync(c => c.TrnartCantidad);

            int salidas = (int)await _context.InvTrnkardices
                .Where(c => c.Anio == anio && c.ArtCodigo == cod && c.TrnartTipo == "SA")
                .SumAsync(c => c.TrnartCantidad);

            int stock = entradas - salidas;
            return stock.ToString();
        }
        public async Task<string> ObtenerCostoCompra(string anio, string cod)
        {
            double costo, cantidad, costoPorUnidad = 0, iva = 1.12; string res = "";
            var ultimaCompra = await _context.InvTrnkardices
                .Where(c => c.Anio == anio && c.ArtCodigo == cod && c.TrnartTipo == "EN")
                .OrderByDescending(c => c.TrnartFechaes)
                .FirstOrDefaultAsync();

            if (ultimaCompra != null)
            {
                costo = (double)ultimaCompra.TrnartCostot;
                cantidad = (double)ultimaCompra.TrnartCantidad;

                costoPorUnidad = (costo / cantidad)*(iva);
                res = costoPorUnidad.ToString();
                return res;
            }

            return "0"; // Si no hay compras, se puede devolver un valor predeterminado.
        }
        public async Task<string> ObtenerCostoVenta(string anio, string cod)
        {
            double iva = 1.12; string res = "";
            List<double> precios = new List<double>();
            var venta = await _context.InvTrnkardices
                .Where(c => c.Anio == anio && c.ArtCodigo == cod && c.TrnartTipo == "SA")
                .OrderByDescending(c => c.TrnartFechaes)
                .FirstAsync();

            VenDetfac? det = await _context.VenDetfacs
                .FirstOrDefaultAsync(c => c.EncfacNumero == venta.TrnartReferencia && c.Anio == anio && c.DetfacCodigo == cod);


            if (venta != null)
            {
                res = ((double)(det?.DetfacPrecio ?? 0)*iva).ToString();
                return res;
            }

            return "0"; // Si no hay ventas, se puede devolver un valor predeterminado.
        }

    }
}
