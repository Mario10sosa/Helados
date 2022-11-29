using Dominio;
using Entidad;
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
    public partial class FrmProductos : FrmBase
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible = false; //id producto

            dataGridView1.Columns[1].Width = 140;//Codigo
            dataGridView1.Columns[2].Width = 260;//Nombre Producto
            dataGridView1.Columns[3].Width = 300;//Decripcion
            dataGridView1.Columns[4].Width = 150;//presentacion
            dataGridView1.Columns[5].Width = 140;//Costo unitario
            dataGridView1.Columns[6].Width = 140;//precio de venta
            dataGridView1.Columns[7].Width = 150;//Tipo de cargo

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaGridView(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }
        private void AgPro_UpdateEventHandler(object sender,FrmAgregarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto AgregarProducto = new FrmAgregarProducto(this);
            AgregarProducto.UpdateEventHandler += AgPro_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }
    }
}
