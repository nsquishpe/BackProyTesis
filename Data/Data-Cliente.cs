using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;


namespace BackProyTesis.Data
{
    public class Data_Cliente
    {
        private context _context;
        public Data_Cliente(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<VenMaecliente>> Listar(string anio)
        {
            return await _context.VenMaeclientes.Where(c => c.Anio == anio).ToListAsync();
        }
        public async Task<ActionResult<VenMaecliente>?> BuscarPorId(string anio, string codigo)
        {
            var cli = await _context.VenMaeclientes.FirstOrDefaultAsync(c => c.Anio == anio && c.CliCodigo == codigo);

            if (cli != null)
                return cli;
            else
                return null;
        }
        public async Task<ActionResult<List<VenMaecliente>>?> BuscarCont(string anio, string codigo)
        {
            var clientes = await _context.VenMaeclientes
                .Where(c => c.Anio == anio && c.CliCodigo.Contains(codigo))
                .ToListAsync();

            if (clientes.Count == 0)
                return null;

            return clientes;
        }
        //CRUD
        public async Task InsertarCliente(VenMaecliente cli)
        {
            _context.VenMaeclientes.Add(cli);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ActualizarCliente(VenMaecliente cli)
        {
            var clitemp = await _context.VenMaeclientes
                .FirstOrDefaultAsync(c => c.Anio == cli.Anio && c.CliCodigo == cli.CliCodigo);
            if (clitemp != null)
            {
                clitemp.Anio = cli.Anio;
                clitemp.CliCodigo = cli.CliCodigo;
                clitemp.CliNombre = cli.CliNombre;
                clitemp.CliNombre = cli.CliNombre;
                clitemp.CliDireccion1 = cli.CliDireccion1;
                clitemp.CliTelefono1 = cli.CliTelefono1;
                clitemp.CliCorreo = cli.CliCorreo;
                clitemp.CliNombrec = clitemp.CliNombre;
                clitemp.CliRucide= clitemp.CliCodigo;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> EliminarCliente(VenMaecliente cli)
        {
            var clitemp = await _context.VenMaeclientes
                .FirstOrDefaultAsync(c => c.Anio == cli.Anio && c.CliCodigo == cli.CliCodigo);

            if (clitemp != null)
            {
                _context.VenMaeclientes.Remove(clitemp);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
