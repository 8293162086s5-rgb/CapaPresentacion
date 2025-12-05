using CapaNegocios.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Repositorios;

namespace AppModeloCapas
{
    public partial class FormHistorialVentas : Form
    {
        private VentaServicio _ventaServicio;

        public FormHistorialVentas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            string cliente = cmbCliente.Text.Trim();
            string tipoPago = cmbTipoPago.Text.Trim();
            string numeroVenta = txtNumeroVenta.Text.Trim();

            var resultados = _ventaServicio.Filtrar(desde, hasta, cliente, tipoPago, numeroVenta);

            dataGridViewVentas.DataSource = null;
            dataGridViewVentas.DataSource = resultados.ToList();
        }

        private void FormHistorial_Ventas_Load(object sender, EventArgs e)
        {

        }
    }
}
