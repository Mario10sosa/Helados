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
    public partial class FrmClientes : FrmBase
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Clientes Clientes = new CDo_Clientes();
        CE_Clientes Cliente = new CE_Clientes();
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DtClientes.Columns[0].Visible = false; //id Cliente

            DtClientes.Columns[1].Width = 140;//Codigo Cliente
            DtClientes.Columns[2].Width = 280;//Nombre Cliente
            DtClientes.Columns[3].Width = 150;//RNC Cliente
            DtClientes.Columns[4].Width = 350;//Direccion Cliente
            DtClientes.Columns[5].Width = 150;//Telefono Cliente
            DtClientes.Columns[6].Width = 240;//Emial Cliente
            DtClientes.Columns[7].Width = 150;//Estado Cliente


            DtClientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtClientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtClientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtClientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Procedimientos.AlternarColorFilaGridView(DtClientes);

        }

        private void CargarDatos()
        {
            DtClientes.DataSource = Procedimientos.CargarDatos("Clientes");
            DtClientes.ClearSelection();
        }

        private void AgProw_UpdateEventhandler(object sender, FrmAgregarCliente.UpdateEventArgs agr)
        {
            CargarDatos();

        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarCliente.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente AgregarCliente = new FrmAgregarCliente(this);
            AgregarCliente.UpdateEventHandler += AgProw_UpdateEventhandler;
            AgregarCliente.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtClientes.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (DtClientes.SelectedRows == null)
                {
                    return;
                }
                else
                {

                    try
                    {
                        FrmEditarCliente EditarCliente = new FrmEditarCliente(this);
                        EditarCliente.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarCliente.TxtIdCliente.Text = DtClientes.SelectedRows[0].Cells[0].Value.ToString();
                        EditarCliente.TxtCodigoCliente.Text = DtClientes.SelectedRows[0].Cells[1].Value.ToString();
                        EditarCliente.TxtNombreCliente.Text = DtClientes.SelectedRows[0].Cells[2].Value.ToString();
                        EditarCliente.TxtRncCliente.Text = DtClientes.SelectedRows[0].Cells[3].Value.ToString();
                        EditarCliente.TxtDireccionCliente.Text = DtClientes.SelectedRows[0].Cells[4].Value.ToString();
                        EditarCliente.MTxtTelefonoCliente.Text = DtClientes.SelectedRows[0].Cells[5].Value.ToString();
                        EditarCliente.TxtEmailCliente.Text = DtClientes.SelectedRows[0].Cells[6].Value.ToString();
                        EditarCliente.CbEstado.Text = DtClientes.SelectedRows[0].Cells[6].Value.ToString();


                        EditarCliente.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe Seleccionar Un Registro Por Favor", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (DtClientes.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro para Eliminar", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (DtClientes.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta seguro que desea eliminar este Cliente", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Cliente.Id_Cliente = Convert.ToInt32(DtClientes.SelectedRows[0].Cells[0].Value.ToString());
                            Clientes.EliminarCliente(Cliente);
                            CargarDatos();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un registro para Eliminar", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
        {
            try
            {
                if (CBTipoBusqueda.Text == "Codigo")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Codigo(Cliente);

                }
                else if (CBTipoBusqueda.Text == "Nombre")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Nombre(Cliente);
                }
                else if (CBTipoBusqueda.Text == "RNC_Cliente")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_RNC_Cliente(Cliente);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente no fue encontrado por: " + ex.Message, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
