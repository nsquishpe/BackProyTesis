using BackProyTesis.Data;
using BackProyTesis.Models;

namespace BackProyTesis.Logic
{
    public class Logic_Servicios
    {
        private Data_Servicios _data;

        public Logic_Servicios(Data_Servicios data)
        {
            _data = data;
        }
        public async Task<List<Servicio>> Listar()
        {
            return await _data.Listar();
        }
    }
}
