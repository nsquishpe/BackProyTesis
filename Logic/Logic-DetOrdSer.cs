using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace BackProyTesis.Logic
{
    public class Logic_DetOrdSer
    {
        private Data_DetOrdSer _data;

        public Logic_DetOrdSer(Data_DetOrdSer data)
        {
            _data = data;
        }
        public async Task<List<DetOrdServicio>?> TraerDetSer(decimal num, string anio)
        {
            return await _data.TraerDetSer(num, anio);
        }
        //CRUD
        public async Task InsertarDetallesServ(decimal num, string anio, List<Servicio> ser)
        {
            await _data.InsertarDetallesServ(num, anio, ser);
        }
        //eliminar
        public async Task<bool> EliminarDetServs(decimal num, string anio)
        {
            return await _data.EliminarDetServs(num, anio);
        }
        //editar
        public async Task<bool> ActualizarDetServs(decimal num, string anio, List<Servicio> ser)
        {
            return await _data.ActualizarDetServs(num, anio, ser);
        }
    }
}
