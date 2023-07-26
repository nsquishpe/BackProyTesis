using BackProyTesis.Data;

namespace BackProyTesis.Logic
{
    public class Logic_Usuario
    {
        private Data_Usuario _data;

        public Logic_Usuario(Data_Usuario data)
        {
            _data = data;
        }
        public async Task<bool> TraerUsuario(string usuIdentificacion, string usuClave)
        {
            return await _data.TraerUsuario(usuIdentificacion, usuClave);
        }
    }
}
