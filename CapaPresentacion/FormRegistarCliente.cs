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
    public partial class FormRegistarCliente : Form
    {
        public FormRegistarCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoCliente.Text.Trim();
            string nombre = txtNombreCliente.Text.Trim();
            string telefono = txtTelefonoCliente.Text.Trim();
            string tipo = cmbTipoCliente.Text;
            string direccion = txtDireccionCliente.Text.Trim();

            dataGridViewClientes.Rows.Add(codigo, nombre, telefono, direccion);
            LimpiarCamposCliente();
        }

        private void LimpiarCamposCliente()
        {
            throw new NotImplementedException();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            LimpiarCamposCliente();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null)
            {
                dataGridViewClientes.Rows.Remove(dataGridViewClientes.CurrentRow);
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCamposCliente();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

            if (dataGridViewClientes.CurrentRow != null)
            {
                string codigo = dataGridViewClientes.CurrentRow.Cells[0].Value?.ToString();
                string nombre = dataGridViewClientes.CurrentRow.Cells[1].Value?.ToString();
                string telefono = dataGridViewClientes.CurrentRow.Cells[2].Value?.ToString();
                string direccion = dataGridViewClientes.CurrentRow.Cells[3].Value?.ToString();

                txtCodigoCliente.Text = codigo;
                txtNombreCliente.Text = nombre;
                txtTelefonoCliente.Text = telefono;
                txtDireccionCliente.Text = direccion;

                dataGridViewClientes.Rows.Remove(dataGridViewClientes.CurrentRow);
            }
        }
    }
}