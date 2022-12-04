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
    public partial class FrmVistaProductos : FrmBase
    {
        public FrmVistaProductos()
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();

        private void FrmVistaProductos_Load(object sender, EventArgs e)
        {
            VistaProducto();
        }

        private void VistaProducto()
        {
            CargarDatos();
            DtVistaProductos.Columns[0].Visible = false; //id producto

            DtVistaProductos.Columns[1].Width = 140;//Codigo
            DtVistaProductos.Columns[2].Width = 260;//Nombre Producto
            DtVistaProductos.Columns[3].Width = 300;//Decripcion
            DtVistaProductos.Columns[4].Width = 150;//presentacion
            DtVistaProductos.Columns[5].Width = 140;//Costo unitario
            DtVistaProductos.Columns[6].Width = 140;//precio de venta
            DtVistaProductos.Columns[7].Width = 150;//Tipo de cargo

            DtVistaProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVistaProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtVistaProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtVistaProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVistaProductos.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            DtVistaProductos.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaGridView(DtVistaProductos);
        }

        private void CargarDatos()
        {
            DtVistaProductos.DataSource = Procedimientos.CargarDatos("Productos");
            DtVistaProductos.ClearSelection();
        }

        private void DtVistaProductos_DoubleClick(object sender, EventArgs e)
        {
            if (DtVistaProductos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
