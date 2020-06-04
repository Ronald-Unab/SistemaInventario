using CapaPresentacion.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Modelos
{
    public class MMarca
    {
        public List<Marca> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from marcas";
            List<Marca> listado = new List<Marca>();
            con.Open();
            listado = con.Query<Marca>(consulta).ToList();
            con.Close();
            return listado;
        }
    }
}
