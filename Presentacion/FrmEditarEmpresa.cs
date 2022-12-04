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
    public partial class FrmEditarEmpresa : FrmBase
    {
        public FrmEditarEmpresa(FrmEmpresas Emmpresas)
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Empresas Empresas = new CDo_Empresas();
        CE_Empresas Empresa = new CE_Empresas();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmEditarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtRncEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void TxtRncEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDireccionEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void TxtDireccionEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MTxtTelefonoEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void MTxtTelefonoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtEmailEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmailEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnEditar.Focus();
                e.Handled = true;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try
            {
                if (TxtNombreEmpresa.Text == string.Empty || TxtRncEmpresa.Text == string.Empty ||
                    TxtDireccionEmpresa.Text == string.Empty || MTxtTelefonoEmpresa.Text == string.Empty ||
                    TxtEmailEmpresa.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe completa todos los campos", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Empresa.Id_Empresa = Convert.ToInt32(TxtIdEmpresa.Text.Trim());

                    Empresa.Nombre = TxtNombreEmpresa.Text.Trim();
                    Empresa.RNC_Empresa = TxtRncEmpresa.Text.Trim();
                    Empresa.Direccion = TxtDireccionEmpresa.Text.Trim();
                    Empresa.Telefono = MTxtTelefonoEmpresa.Text.Trim();
                    Empresa.Email = TxtEmailEmpresa.Text.Trim();
                    


                    Empresas.EditarEmpresa(Empresa);
                    MessageBox.Show("El Empresa fue Editado correctamente", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    this.Close();
                    Actualizar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Empresa no fue editado por: " + ex.Message, "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
