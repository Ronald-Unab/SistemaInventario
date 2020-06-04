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
    public class MProducto
    {
        public List<Producto> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from productos";
            List<Producto> listado = new List<Producto>();
            con.Open();
            listado = con.Query<Producto>(consulta).ToList();
            con.Close();
            return listado;
        }

        internal void guardar(Producto p)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_InsertarProducto";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", p.nombre,DbType.String);
            parametros.Add("@codigoInterno", p.codigoInterno,DbType.String);
            parametros.Add("@marca", p.marcaId,DbType.Int32);
            parametros.Add("@proveedor", p.proveedorId, DbType.Int32);
            parametros.Add("@categoria", p.categoriaId, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}
