using BackProyTesis.Data;
using BackProyTesis.Models;

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
    }
}
