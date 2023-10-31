using BackProyTesis.Data;
using BackProyTesis.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BackProyTesis.Logic
{
    public class Logic_Articulo
    {
        private Data_Articulo _data;

        public Logic_Articulo(Data_Articulo data)
        {
            _data = data;
        }
        public async Task<ActionResult<List<InvMaearticulo>>?> ListarPorGrupo(string anio, string cod)
        {
            return await _data.ListarPorGrupo(anio, cod);
        }
        //REPORTES
        public IEnumerable<ReporteArticulos> ReporteGeneral(string anio, string bodega, string fecha)
        {
            return _data.ReporteGeneral(anio, bodega, fecha);
        }
        public IEnumerable<ReporteArticulos> ReportePorGrupo(string anio, string bodega, string fecha, string grup)
        {
            return _data.ReportePorGrupo(anio, bodega, fecha, grup);
        }
    }
}
