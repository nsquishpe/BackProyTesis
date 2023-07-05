using BackProyTesis.Data;
using BackProyTesis.Models;

namespace BackProyTesis.Logic
{
    public class Logic_Cliente
    {
        private Data_Cliente _data;

        public Logic_Cliente(Data_Cliente data)
        {
            _data = data;
        }
        public async Task<List<VenMaecliente>> Listar(string anio)
        {
            return await _data.Listar(anio);
        }
    }
}
