using BackProyTesis.Data;
using BackProyTesis.Models;

namespace BackProyTesis.Logic
{
    public class Logic_Color
    {
        private Data_Colores _data;

        public Logic_Color(Data_Colores data)
        {
            _data = data;
        }
        public async Task<List<VenMaecolor>> Listar()
        {
            return await _data.Listar();
        }
    }
}
