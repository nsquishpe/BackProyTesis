using BackProyTesis.Data;
using BackProyTesis.Models;

namespace BackProyTesis.Logic
{
    public class Logic_Detfac
    {
        private Data_Detfac _data;

        public Logic_Detfac(Data_Detfac data)
        {
            _data = data;
        }
        public async Task<List<VenDetfac>> TraerDetFac(string anio, string num)
        {
            return await _data.TraerDetFac(anio, num);
        }
    }
}
