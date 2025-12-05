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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void Administrar_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos f = new FormProductos();
            f.Show();

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStock f = new FormStock();
          
            f.Show();

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores f = new FormProveedores();
          
            f.Show();

        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas f = new FormVentas();
          
            f.Show();

        }

        private void historiaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialVentas f = new FormHistorialVentas();
            
            f.Show();

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistarCliente f = new FormRegistarCliente();
        
            f.Show();

        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCuentasCobrar f = new FormCuentasCobrar();
           
            f.Show();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompras f = new FormCompras();
         
            f.Show();

        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialVentas f = new FormHistorialVentas();
           
            f.Show();

        }
    }
}
