using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BackProyTesis.Data
{
    public class Data_Vehiculo
    {
        private context _context;
        public Data_Vehiculo(context contexto)
        {
            _context = contexto;
        }
        public async Task<ActionResult<VenVhcspcf>?> BuscarPorPlacFac(string anio, string plac, string nfac)
        {
            var fac = await _context.VenVhcspcfs.FirstOrDefaultAsync(c => c.Anio == anio && c.EncfacNumero == nfac && c.VhcspcfPlaca == plac);

            if (fac != null)
                return fac;
            else
                return null;
        }
        public async Task<List<string>> AutosPorAnio(string anio)
        {
            var placas = await _context.VenVhcspcfs
                                      .Where(v => v.Anio == anio)
                                      .Select(v => v.VhcspcfPlaca)
                                      .Distinct()
                                      .ToListAsync();

            return placas!;
        }
        public async Task<Dictionary<string, int>> AutosPorMarca(string anio)
        {
            var conteoMarcas = await _context.VenVhcspcfs
                .Where(v => v.Anio == anio && !string.IsNullOrEmpty(v.VhcspcfMarcaDescrip))
                .GroupBy(v => v.VhcspcfMarcaDescrip)
                .ToDictionaryAsync(g => g.Key ?? string.Empty, g => g.Select(v => v.VhcspcfPlaca).Distinct().Count());

            return conteoMarcas!;
        }
        public async Task<List<VenVhcspcf>?> BuscarPorCli(string anio, string cli)
        {
            var vehiculosRegistrados = await (
                from fac in _context.VenEncfacs
                join vehiculo in _context.VenVhcspcfs on fac.EncfacNumero equals vehiculo.EncfacNumero
                where fac.CliCodigo == cli && fac.Anio == anio && vehiculo.Anio == anio
                group vehiculo by vehiculo.VhcspcfPlaca into grupo
                select grupo.First()
            ).ToListAsync();

            return vehiculosRegistrados;
        }
    }
}
