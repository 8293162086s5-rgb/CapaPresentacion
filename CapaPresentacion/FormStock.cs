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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormStock_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiarAjuste_Click(object sender, EventArgs e)
        {
            cmbProducto.SelectedIndex = -1;
            txtStockActual.Text = "";
            nudAjusteCantidad.Value = 0;
            cmbMotivoAjuste.SelectedIndex = -1;
            dtpFechaAjuste.Value = DateTime.Today;
        }

        private void btnAplicarAjuste_Click(object sender, EventArgs e)
        {
            string producto = cmbProducto.Text;
            string stockActualTexto = txtStockActual.Text.Trim();
            int ajuste = (int)nudAjusteCantidad.Value;
            string motivo = cmbMotivoAjuste.Text;
            DateTime fecha = dtpFechaAjuste.Value;

            if (string.IsNullOrEmpty(producto) || string.IsNullOrEmpty(stockActualTexto) || string.IsNullOrEmpty(motivo))
            {
                MessageBox.Show("Completa todos los campos antes de aplicar el ajuste.");
                return;
            }

            if (!int.TryParse(stockActualTexto, out int stockActual))
            {
                MessageBox.Show("El stock actual debe ser un número válido.");
                return;
            }

            int nuevoStock = stockActual + ajuste;

            dataGridViewProductos.Rows.Add("COD", producto, motivo, nuevoStock, "MIN");

            txtStockActual.Text = nuevoStock.ToString();
            nudAjusteCantidad.Value = 0;
        }
    }
}
