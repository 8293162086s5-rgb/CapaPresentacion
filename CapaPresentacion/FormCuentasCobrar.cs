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
    public partial class FormCuentasCobrar : Form
    {
        public FormCuentasCobrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarDeuda_Click(object sender, EventArgs e)
        {
            string cliente = cmbCliente.Text;
            decimal monto = nudMontoAdeudado.Value;
            DateTime fecha = dtpFechaDeuda.Value;
            string estado = cmbEstado.Text;

            dataGridViewDeudas.Rows.Add(cliente, monto, fecha.ToShortDateString(), estado);
            LimpiarCamposDeuda();
        }

        private void LimpiarCamposDeuda()
        {
            throw new NotImplementedException();
        }

        private void btnCancelarDeuda_Click(object sender, EventArgs e)
        {
            LimpiarCamposDeuda();
        }

        private void btnEliminarDeuda_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeudas.CurrentRow != null)
            {
                dataGridViewDeudas.Rows.Remove(dataGridViewDeudas.CurrentRow);
            }
        }
    }
}
