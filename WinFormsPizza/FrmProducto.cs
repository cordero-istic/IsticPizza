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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // 🔹 Validar datos obligatorios
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecio.Text))
            {
                MessageBox.Show("Nombre y Precio son obligatorios",
                              "Validación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Crear instancia del producto
            Producto producto = new Producto()
            {
                IdProducto = 1, // TODO: implementar auto-incremental
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                Precio = double.TryParse(TxtPrecio.Text, out var precio) ? precio : 0,
                TipoProducto = TxtTipoProducto.Text,
                UnidadMedida = TxtUnidadMedida.Text,
                ImageUrl = TxtImageUrl.Text
            };

            // 🔹 Persistir usando el patrón del modelo
            producto.AgregarProducto(producto);

            // 🔹 Navegar a la lista de productos
            this.Close();
            FrmListaProductos frmLista = new FrmListaProductos();
            frmLista.ShowDialog();
        }
    }
}
