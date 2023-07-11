using BackProyTesis.Data;
using BackProyTesis.Models;
using Microsoft.EntityFrameworkCore;

namespace BackProyTesis.Logic
{
    public class Logic_GrupoRep
    {
        private Data_GrupoRep _data;

        public Logic_GrupoRep(Data_GrupoRep data)
        {
            _data = data;
        }
        public async Task<List<InvMaegrupo>> Listar(string anio)
        {
            return await _data.Listar(anio);
        }
    }
}
