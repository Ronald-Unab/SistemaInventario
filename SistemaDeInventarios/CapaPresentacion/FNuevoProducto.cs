using CapaPresentacion.Controladores;
using CapaPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FNuevoProducto : Form
    {
        public FNuevoProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nuevo
            //1- Moverme al final del BS
            productoBindingSource.MoveLast();
            productoBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productoBindingSource.EndEdit();
            Producto p = new Producto();
            p = (Producto) productoBindingSource.Current;
            CProducto cproducto = new CProducto();
            cproducto.guardar(p);
            this.Close();

        }

        private void FNuevoProducto_Load(object sender, EventArgs e)
        {
            CMarca cMarca = new CMarca();
            marcaBindingSource.DataSource = cMarca.Listado();
        }
    }
}
