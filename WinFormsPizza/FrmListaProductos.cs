using ConsolePizza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPizza
{
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            Producto productoModel = new Producto();
            var lista = productoModel.GetProductos();

            // 👇 Opción A: DataGridView (recomendado)
            dataGridProductos.DataSource = lista;

            // 👇 Opción B: ListBox (más simple)
            // lstProductos.Items.Clear();
            // foreach(var p in lista)
            //     lstProductos.Items.Add($"{p.Nombre} - ${p.Precio}");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto producto = new();
            producto.ShowDialog();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
