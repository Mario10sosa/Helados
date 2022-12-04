using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Dominio;

namespace Presentacion
{
    public partial class FrmEmpresas : FrmBase
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Empresas Empresas = new CDo_Empresas();
        CE_Empresas Empresa = new CE_Empresas();



        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            CargarDatos();

            DtEmpresa.Columns[0].Visible = false; //id Empresa


            DtEmpresa.Columns[1].Width = 300;//Nombre Empresa
            DtEmpresa.Columns[2].Width = 150;//RNC Empresa
            DtEmpresa.Columns[3].Width = 350;//Direccion Empresa
            DtEmpresa.Columns[4].Width = 150;//Telefono Empresa
            DtEmpresa.Columns[5].Width = 220;//Emial Empresa


            Procedimientos.AlternarColorFilaGridView(DtEmpresa);
        }

        private void CargarDatos()
        {
            DtEmpresa.DataSource = Procedimientos.CargarDatos("Empresa");
            DtEmpresa.ClearSelection();
        }

        private void AgProw_UpdateEventhandler(object sender, FrmAgregarEmpresa.UpdateEventArgs agr)
        {
            CargarDatos();

        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarEmpresa.UpdateEventArgs args)
        {
            CargarDatos();
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpresa AgregarEmpresario = new FrmAgregarEmpresa(this);
            AgregarEmpresario.UpdateEventHandler += AgProw_UpdateEventhandler;
            AgregarEmpresario.ShowDialog();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtEmpresa.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (DtEmpresa.SelectedRows == null)
                {
                    return;
                }
                else
                {

                    try
                    {
                        FrmEditarEmpresa EditarEmpresa = new FrmEditarEmpresa(this);
                        EditarEmpresa.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarEmpresa.TxtIdEmpresa.Text = DtEmpresa.SelectedRows[0].Cells[0].Value.ToString();

                        EditarEmpresa.TxtNombreEmpresa.Text = DtEmpresa.SelectedRows[0].Cells[1].Value.ToString();
                        EditarEmpresa.TxtRncEmpresa.Text = DtEmpresa.SelectedRows[0].Cells[2].Value.ToString();
                        EditarEmpresa.TxtDireccionEmpresa.Text = DtEmpresa.SelectedRows[0].Cells[3].Value.ToString();
                        EditarEmpresa.MTxtTelefonoEmpresa.Text = DtEmpresa.SelectedRows[0].Cells[4].Value.ToString();
                        EditarEmpresa.TxtEmailEmpresa.Text = DtEmpresa.SelectedRows[0].Cells[5].Value.ToString();



                        EditarEmpresa.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe Seleccionar Un Registro Por Favor", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (DtEmpresa.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro para Eliminar", "Eliminar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (DtEmpresa.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta seguro que desea eliminar este Empresa", "Eliminar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Empresa.Id_Empresa = Convert.ToInt32(DtEmpresa.SelectedRows[0].Cells[0].Value.ToString());
                            Empresas.EliminarEmpresa(Empresa);
                            CargarDatos();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un registro para Eliminar", "Eliminar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
    }
}
