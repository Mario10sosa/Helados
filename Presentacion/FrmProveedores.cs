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
    public partial class FrmProveedores : FrmBase
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Proveedores Proveedores = new CDo_Proveedores();
        CE_Proveedores Proveedor = new CE_Proveedores();

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DtProveedor.Columns[0].Visible = false; //id Proveedor

            DtProveedor.Columns[1].Width = 140;//Codigo Proveedor
            DtProveedor.Columns[2].Width = 280;//Nombre Proveedor
            DtProveedor.Columns[3].Width = 150;//RNC Proveedor
            DtProveedor.Columns[4].Width = 350;//Direccion Proveedor
            DtProveedor.Columns[5].Width = 150;//Telefono Proveedor
            DtProveedor.Columns[6].Width = 240;//Emial Proveedor
            

            DtProveedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProveedor.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProveedor.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Procedimientos.AlternarColorFilaGridView(DtProveedor);
        }

        private void CargarDatos()
        {
            DtProveedor.DataSource = Procedimientos.CargarDatos("Proveedores");
            DtProveedor.ClearSelection();
        }

        private void AgProw_UpdateEventhandler(object sender, FrmAgregarProveedor.UpdateEventArgs agr)
        {
            CargarDatos();

        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarProveedor.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmAgregarProveedor AgregarProveedor = new FrmAgregarProveedor(this);
            AgregarProveedor.UpdateEventHandler += AgProw_UpdateEventhandler;
            AgregarProveedor.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtProveedor.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (DtProveedor.SelectedRows == null)
                {
                    return;
                }
                else
                {

                    try
                    {
                        FrmEditarProveedor EditarProveedor = new FrmEditarProveedor(this);
                        EditarProveedor.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarProveedor.TxtIdProveedor.Text = DtProveedor.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProveedor.TxtCodigoProveedor.Text = DtProveedor.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProveedor.TxtNombreProveedor.Text = DtProveedor.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProveedor.TxtRncProveedor.Text = DtProveedor.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProveedor.TxtDireccionProveedor.Text = DtProveedor.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProveedor.MTxtTelefonoProveedor.Text = DtProveedor.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProveedor.TxtEmailProveedor.Text = DtProveedor.SelectedRows[0].Cells[6].Value.ToString();
                       

                        EditarProveedor.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe Seleccionar Un Registro Por Favor", "Editar Prodcuto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public override void Eliminar()
        {
            if (DtProveedor.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro para Eliminar", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (DtProveedor.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta seguro que desea eliminar este Proveedor", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Proveedor.Id_Proveedor = Convert.ToInt32(DtProveedor.SelectedRows[0].Cells[0].Value.ToString());
                            Proveedores.EliminarProvedor(Proveedor);
                            CargarDatos();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un registro para Eliminar", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void TxtBuscarProveedores_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
        {
            try
            {
                if (CBTipoBusqueda.Text == "Codigo")
                {
                    Proveedor.Buscar = TxtBuscarProveedores.Text.Trim();
                    DtProveedor.DataSource = Proveedores.Buscar_Provedor_Codigo(Proveedor);

                }
                else if (CBTipoBusqueda.Text == "Nombre")
                {
                    Proveedor.Buscar = TxtBuscarProveedores.Text.Trim();
                    DtProveedor.DataSource = Proveedores.Buscar_Provedor_Nombre(Proveedor);
                }
                else if (CBTipoBusqueda.Text == "RNC_Proveedor")
                {
                    Proveedor.Buscar = TxtBuscarProveedores.Text.Trim();
                    DtProveedor.DataSource = Proveedores.Buscar_Provedor_RNC(Proveedor);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El Proveedor no fue encontrado por: " + ex.Message, "Buscar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
