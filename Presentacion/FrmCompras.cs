using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Entidad;

namespace Presentacion
{
    public partial class FrmCompras : FrmBase
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_IngresoProductos IngresoProductos = new CDo_IngresoProductos();
        CE_Ingreso_Productos IngresoProducto = new CE_Ingreso_Productos();

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            CargarDatos();

            DtCompra.Columns[0].Visible = false;//id ingreso

            DtCompra.Columns[1].Width = 160; //Numero de ingreso
            DtCompra.Columns[2].Width = 370; //Nombre proveedor
            DtCompra.Columns[3].Width = 180;//Fecha Ingreso
            DtCompra.Columns[4].Width = 200;//Comprobante
            DtCompra.Columns[5].Width = 180;//Monto total
            DtCompra.Columns[6].Width = 180;//Estado

            
            DtCompra.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtCompra.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtCompra.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtCompra.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            DtCompra.Columns[5].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaGridView(DtCompra);
        }

        private void CargarDatos()
        {
            DtCompra.DataSource = IngresoProductos.MostrarIngresoProductos();
            DtCompra.ClearSelection();
        }

        private void AgIn_UpdateEventHandler(object sender, FrmAgregarIngresoProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmAgregarIngresoProducto AgregarProducto = new FrmAgregarIngresoProducto(this);
            AgregarProducto.UpdateEventHandler += AgIn_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }
    }
}
