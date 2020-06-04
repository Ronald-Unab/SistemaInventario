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
    public partial class FProductos : Form
    {
        public FProductos()
        {
            InitializeComponent();
        }

        private void FProductos_Load(object sender, EventArgs e)
        {
            CProducto producto = new CProducto();
            CMarca cMarca = new CMarca();
            marcaBindingSource.DataSource = cMarca.Listado();
            productoBindingSource.DataSource = producto.Listado();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNuevoProducto f = new FNuevoProducto();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p = (Producto)productoBindingSource.Current;

            FActualizarProducto f = new FActualizarProducto(p);
            f.ShowDialog();
        }
    }
}
