using CapaPresentacion.Entidades;
using CapaPresentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Controladores
{
    public class CProducto
    {
        MProducto modelo = new MProducto();
        public List<Producto> Listado()
        {
            return modelo.Listado();
        }

        internal void guardar(Producto p)
        {
            modelo.guardar(p);
        }
    }
}
