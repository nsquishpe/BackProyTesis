using BackProyTesis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_CabOrdTrab
    {
        private context _context;
        public Data_CabOrdTrab(context contexto)
        {
            _context = contexto;
        }
        public async Task<ActionResult<List<CabOrdenTrabajo>>?> BuscarPorCliCont(string anio, string cli)
        {
            var ords = await _context.CabOrdenTrabajos
                .Where(c => c.OrdAnio == anio && c.CliCodigo.Contains(cli))
                .ToListAsync();

            if (ords.Count == 0)
                return null;

            return ords;
        }
        public async Task<ActionResult<List<CabOrdenTrabajo>>?> BuscarPorPlacaCont(string anio, string plac)
        {
            var ords = await _context.CabOrdenTrabajos
                .Where(c => c.OrdAnio == anio && c.OrdPlaca.Contains(plac))
                .ToListAsync();

            if (ords.Count == 0)
                return null;

            return ords;
        }
        public async Task<ActionResult<CabOrdenTrabajo>?> BuscarPorNum(string anio, decimal num)
        {
            var ord = await _context.CabOrdenTrabajos.
                FirstOrDefaultAsync(c => c.OrdAnio == anio && c.OrdNumero == num);

            if (ord != null)
                return ord;
            else
                return null;
        }
        public async Task<string> AsignarNumOrd(string anio)
        {
            var ultimoNumero = await _context.CabOrdenTrabajos
                .Where(o => o.OrdAnio == anio)
                .MaxAsync(o => (decimal?)o.OrdNumero) ?? 0;

            return (ultimoNumero + 1).ToString();
        }
        //Auxiliares
        private CabOrdenTrabajo ? CabOrdTrab_PorId(decimal id, string anio)
        {
            return _context.CabOrdenTrabajos.Where(ord => ord.OrdNumero == id && ord.OrdAnio == anio).SingleOrDefault();
        }

        //CRUD
        public async Task InsertarOrdTrabCab(CabOrdenTrabajo ord)
        {
            //Verificar existencia orden
            if(CabOrdTrab_PorId(ord.OrdNumero, ord.OrdAnio) == null) //no existe
            {
                _context.CabOrdenTrabajos.Add(ord);
                await _context.SaveChangesAsync();
            }
            //Si existe, Edita
            else
            {
                await ActualizarOrdTrabCab(ord);
            }
        }
        public async Task<bool> ActualizarOrdTrabCab(CabOrdenTrabajo ord)
        {
            CabOrdenTrabajo? ordtemp = CabOrdTrab_PorId(ord.OrdNumero, ord.OrdAnio);
            if (ordtemp != null)
            {
                ordtemp.OrdFecha = ord.OrdFecha;
                ordtemp.OrdObsv = ord.OrdObsv;
                ordtemp.OrdObsv1 = ord.OrdObsv1;
                ordtemp.OrdPlaca = ord.OrdPlaca;
                ordtemp.OrdKm = ord.OrdKm;
                ordtemp.VehmarmodCodigo = ord.VehmarmodCodigo;
                ordtemp.MaecolorCodigo = ord.MaecolorCodigo;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> EliminarOrdTrabCab(CabOrdenTrabajo ord)
        {
            CabOrdenTrabajo? ordtemp = CabOrdTrab_PorId(ord.OrdNumero, ord.OrdAnio);

            if (ordtemp != null)
            {
                _context.CabOrdenTrabajos.Remove(ordtemp);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
