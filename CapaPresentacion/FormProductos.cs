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
using CapaDatos.Entidades;
using CapaNegocios.Servicios;


namespace AppModeloCapas
{
    public partial class FormProductos : Form



    {
        private readonly ProductoServicio _productoServicio;
        public FormProductos()
        {
            InitializeComponent();
            var repoProducto = new RepositorioProductoMem();
            _productoServicio = new ProductoServicio(repoProducto);

        }



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                PrecioCompra = decimal.TryParse(txtPrecioCompra.Text, out var pc) ? pc : 0,
                PrecioVenta = decimal.TryParse(txtPrecioVenta.Text, out var pv) ? pv : 0,
                StockInicial = (int)nudStockInicial.Value,
                StockMinimo = (int)nudStockMinimo.Value
            };

            _productoServicio.Insertar(producto);
            CargarProductos();
        }
        private void CargarProductos()
        {
            var lista = _productoServicio.Listar().ToList();
            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.DataSource = lista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                var producto = (Producto)dataGridViewProductos.CurrentRow.DataBoundItem;
                _productoServicio.Eliminar(producto.Codigo);
                CargarProductos();
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            nudStockInicial.Value = 0;
            nudStockMinimo.Value = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                var producto = (Producto)dataGridViewProductos.CurrentRow.DataBoundItem;

                txtCodigo.Text = producto.Codigo.ToString();
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                cmbCategoria.Text = producto.Categoria;
                cmbProveedor.Text = producto.Proveedor;
                txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                nudStockInicial.Value = producto.StockInicial;
                nudStockMinimo.Value = producto.StockMinimo;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}