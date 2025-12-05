using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModeloCapas
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = cmbProducto.Text;
            decimal precio = decimal.TryParse(txtPrecio.Text, out var p) ? p : 0;
            int cantidad = (int)nudCantidad.Value;
            int stockDisponible = (int)nudStockDisponible.Value;

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("La cantidad supera el stock disponible.");
                return;
            }

            decimal subtotal = precio * cantidad;
            txtSubTotal.Text = subtotal.ToString("0.00");

            // Agregar fila al DataGridView
            dataGridViewDetalle.Rows.Add(nombreProducto, precio, cantidad, subtotal);

            // Actualizar stock disponible
            nudStockDisponible.Value -= cantidad;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbProducto.SelectedIndex = -1;
            txtPrecio.Text = "";
            nudStockDisponible.Value = 0;
            nudCantidad.Value = 0;
            txtSubTotal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
