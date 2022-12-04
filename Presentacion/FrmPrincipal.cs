using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void TmTiempo_Tick(object sender, EventArgs e)
        {
            LBHora.Text = DateTime.Now.ToLongTimeString();
            LBFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos Productos = new FrmProductos();
            Productos.ShowDialog();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInventario Inventario = new FrmInventario();
            Inventario.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores Proveedores = new FrmProveedores();
            Proveedores.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Clientes = new FrmClientes();
            Clientes.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresas Empresa = new FrmEmpresas();
            Empresa.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras compra= new FrmCompras();
            compra.ShowDialog();
        }
    }
}
