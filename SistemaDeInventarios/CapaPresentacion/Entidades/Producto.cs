using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades
{
    public class Producto
    {
        public int productoId { get; set; }
        public string nombre { get; set; }
        public string codigoInterno { get; set; }
        public int marcaId { get; set; }
        public int proveedorId { get; set; }
        public int categoriaId { get; set; }
    }
}
