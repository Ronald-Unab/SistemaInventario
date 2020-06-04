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
    public partial class FActualizarProducto : Form
    {
        Producto p = new Producto();
        public FActualizarProducto()
        {
            InitializeComponent();
        }
        public FActualizarProducto(Producto p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void FActualizarProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto pEditar = new Producto();
            productoBindingSource.EndEdit();
            pEditar = (Producto)productoBindingSource.Current;


        }
    }
}
