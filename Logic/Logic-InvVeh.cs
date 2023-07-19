using BackProyTesis.Data;
using BackProyTesis.Models;

namespace BackProyTesis.Logic
{
    public class Logic_InvVeh
    {
        private Data_InvVeh _data;

        public Logic_InvVeh(Data_InvVeh data)
        {
            _data = data;
        }
        public async Task<List<InvVehiculo>> Listar()
        {
            return await _data.Listar();
        }
    }
}
