using BackProyTesis.Data;
using BackProyTesis.Models;

namespace BackProyTesis.Logic
{
    public class Logic_DetOrdInv
    {
        private Data_DetOrdInv _data;

        public Logic_DetOrdInv(Data_DetOrdInv data)
        {
            _data = data;
        }
        public async Task<List<DetOrdInventario>?> TraerDetInv(decimal num, string anio)
        {
            return await _data.TraerDetInv(num, anio);
        }
        //CRUD
        public async Task<bool> InsertarDetallesInv(decimal num, List<DetOrdInventario> inv)
        {
            return await _data.InsertarDetallesInv(num, inv );
        }
        //eliminar
        public async Task<bool> EliminarDetInvs(decimal num, string anio)
        {
            return await _data.EliminarDetInvs(num, anio);
        }
        //editar
        public async Task<bool> ActualizarDetInvs(decimal num, List<DetOrdInventario> inv)
        {
            return await _data.ActualizarDetInvs(num, inv);
        }
    }
}
