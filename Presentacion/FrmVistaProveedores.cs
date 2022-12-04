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
    public partial class FrmVistaProveedores : FrmBase
    {
        public FrmVistaProveedores()
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();

        private void FrmVistaProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DtVistaProveedor.Columns[0].Visible = false; //id Proveedor

            DtVistaProveedor.Columns[1].Width = 140;//Codigo Proveedor
            DtVistaProveedor.Columns[2].Width = 280;//Nombre Proveedor
            DtVistaProveedor.Columns[3].Width = 150;//RNC Proveedor
            DtVistaProveedor.Columns[4].Width = 350;//Direccion Proveedor
            DtVistaProveedor.Columns[5].Width = 150;//Telefono Proveedor
            DtVistaProveedor.Columns[6].Width = 240;//Emial Proveedor


            DtVistaProveedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVistaProveedor.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVistaProveedor.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Procedimientos.AlternarColorFilaGridView(DtVistaProveedor);

        }

        private void CargarDatos()
        {
            DtVistaProveedor.DataSource = Procedimientos.CargarDatos("Proveedores");
            DtVistaProveedor.ClearSelection();
        }

        private void DtVistaProveedor_DoubleClick(object sender, EventArgs e)
        {
            if(DtVistaProveedor.Rows.Count == 0)
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
