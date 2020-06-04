using CapaPresentacion.Entidades;
using CapaPresentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Controladores
{
    public class CMarca
    {
        MMarca mMarca = new MMarca();
        public List<Marca> Listado()
        {
            return mMarca.Listado();
        }

    }
}
