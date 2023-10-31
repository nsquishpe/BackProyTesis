using BackProyTesis.Data;
using BackProyTesis.Models;

namespace BackProyTesis.Logic
{
    public class Logic_Marca
    {
        private Data_Marcas _data;

        public Logic_Marca(Data_Marcas data)
        {
            _data = data;
        }
        public async Task<List<VenVehmarmod>> Listar()
        {
            return await _data.Listar();
        }
    }
}
