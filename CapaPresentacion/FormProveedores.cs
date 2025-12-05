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
    public partial class FormProveedores : Form
    {
        private object dataGridViewProveedores;

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoProveedor.Text.Trim();
            string nombre = txtNombreProveedor.Text.Trim();
            string telefono = txtTelefonoProveedor.Text.Trim();
            string tipo = cmbTipoProveedor.Text;
            string direccion = txtDireccionProveedor.Text.Trim();

            ataGridViewProveedores.Rows.Add(codigo, nombre, telefono, direccion);
            LimpiarCamposProveedor();
        }

        private void LimpiarCamposProveedor()
        {
            throw new NotImplementedException();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            LimpiarCamposProveedor();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (ataGridViewProveedores.CurrentRow != null)
            {
                ataGridViewProveedores.Rows.Remove(ataGridViewProveedores.CurrentRow);
            }
        }

        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            LimpiarCamposProveedor();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (ataGridViewProveedores.CurrentRow != null)
            {
                string codigo = ataGridViewProveedores.CurrentRow.Cells[0].Value.ToString();
                string nombre = ataGridViewProveedores.CurrentRow.Cells[1].Value.ToString();
                string telefono = ataGridViewProveedores.CurrentRow.Cells[2].Value.ToString();
                string direccion = ataGridViewProveedores.CurrentRow.Cells[3].Value.ToString();

                txtCodigoProveedor.Text = codigo;
                txtNombreProveedor.Text = nombre;
                txtTelefonoProveedor.Text = telefono;
                txtDireccionProveedor.Text = direccion;

                ataGridViewProveedores.Rows.Remove(ataGridViewProveedores.CurrentRow);
            }
        }

        private void btnSalirProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

