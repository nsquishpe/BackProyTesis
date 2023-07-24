using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackProyTesis.Data
{
    public class Data_DetOrdSer
    {
        private context _context;
        public Data_DetOrdSer(context contexto)
        {
            _context = contexto;
        }
        public async Task<List<DetOrdServicio>?> TraerDetSer(decimal num, string anio)
        {
            var det_servs = await _context.DetOrdServicios
                .Where(d => d.OrdNumero == num && d.OrdAnio == anio)
                .ToListAsync();

            if (det_servs.Count == 0)
                return null;

            return det_servs;
        }
        //auxiliar
        private List<DetOrdServicio>?  detalles(decimal num, string anio)
        {
            var det_servs = _context.DetOrdServicios
                .Where(d => d.OrdNumero == num && d.OrdAnio == anio)
                .ToList();

            if (det_servs.Count == 0)
                return null;

            return det_servs;
        }
        //CRUD
        public async Task InsertarDetallesServ(decimal num, string anio, List<Servicio> ser)
        {
            //Verificar existencia detalle
            if (detalles(num, anio) == null) //no existe
            {
                for (int i = 0; i < ser.Count; i++)
                {
                    DetOrdServicio d = new DetOrdServicio();
                    d.OrdNumero = num;
                    d.OrdAnio = anio;
                    d.DetSerLinea = i + 1;
                    d.SerCodigo = ser[i].SerCodigo;
                    d.DetDescrip = ser[i].SerDescrip;
                    _context.DetOrdServicios.Add(d);
                    await _context.SaveChangesAsync();
                }
            }
        }
        //eliminar
        public async Task<bool> EliminarDetServs(decimal num, string anio)
        {
            List < DetOrdServicio > det_serv = detalles(num, anio)!;
            if (det_serv!= null)
            {
                for (int i = 0; i < det_serv.Count(); i++)
                {
                    _context.DetOrdServicios.Remove(det_serv[i]);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            return false;
        }
        //editar
        public async Task<bool> ActualizarDetServs(decimal num, string anio, List<Servicio> ser)
        {
            //Verificar existencia detalle
            if (detalles(num, anio) != null) //existe
            {
                await EliminarDetServs(num, anio); //elimino lineas existentes
                await InsertarDetallesServ(num, anio, ser); //ingreso nuevas
                
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

    }
}
