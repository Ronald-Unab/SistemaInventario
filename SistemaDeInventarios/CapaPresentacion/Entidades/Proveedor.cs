using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades
{
    public class Proveedor
    {
        public int proveedorId { get; set; }
        public string nombre { get; set; }
        public string nombreComercial { get; set; }
        public string nit { get; set; }
        public string nrc { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
    }
}
