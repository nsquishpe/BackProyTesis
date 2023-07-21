using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Data
{
    public class Data_DetOrdInv
    {
        private context _context;
        public Data_DetOrdInv(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<DetOrdInventario>?> TraerDetInv(decimal num, string anio)
        {
            var det_invs = await _context.DetOrdInventarios
                .Where(d => d.OrdNumero == num && d.OrdAnio == anio)
                .ToListAsync();

            if (det_invs.Count == 0)
                return null;

            return det_invs;
        }
        //auxiliar
        private List<DetOrdInventario>? detalles(decimal num, string anio)
        {
            var det_invs =  _context.DetOrdInventarios
                .Where(d => d.OrdNumero == num && d.OrdAnio == anio)
                .ToList();

            if (det_invs.Count == 0)
                return null;

            return det_invs;
        }
        //CRUD
        public async Task<bool> InsertarDetallesInv(decimal num, List<DetOrdInventario> inv)
        {
            if(inv.Count != 0)
            {
                //Verificar existencia detalle
                if (detalles(num, inv[0].OrdAnio) == null) //no existe
                {
                    for (int i = 0; i < inv.Count; i++)
                    {
                        inv[i].DetInvLinea = i + 1;
                        _context.DetOrdInventarios.Add(inv[i]);
                        await _context.SaveChangesAsync();
                    }
                    return true;
                }
            }
            else
            {
                await ActualizarDetInvs(num, inv);
            }
            return false;
        }
        //eliminar
        public async Task<bool> EliminarDetInvs(decimal num, string anio)
        {
            List<DetOrdInventario> det_inv = detalles(num, anio)!;
            if (det_inv != null)
            {
                for (int i = 0; i < det_inv.Count(); i++)
                {
                    _context.DetOrdInventarios.Remove(det_inv[i]);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            return false;
        }
        //editar
        public async Task<bool> ActualizarDetInvs(decimal num, List<DetOrdInventario> inv)
        {
            if(inv.Count != 0) {
                //Verificar existencia detalle
                if (detalles(num, inv[0].OrdAnio) != null) //existe
                {
                    await EliminarDetInvs(num, inv[0].OrdAnio); //elimino lineas existentes
                    await InsertarDetallesInv(num, inv); //ingreso nuevas

                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
