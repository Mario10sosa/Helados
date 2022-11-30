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
    public partial class FrmEditarCliente : FrmBase
    {
        public FrmEditarCliente(FrmClientes Clientes)
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Clientes Clientes = new CDo_Clientes();
        CE_Clientes Cliente = new CE_Clientes();

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

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtRncCliente.Focus();
                e.Handled = true;
            }
        }

        private void TxtRncCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDireccionCliente.Focus();
                e.Handled = true;
            }
        }

        private void TxtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MTxtTelefonoCliente.Focus();
                e.Handled = true;
            }
        }

        private void MTxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtEmailCliente.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CbEstado.Focus();
                e.Handled = true;
            }
        }

        private void CbEstado_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TxtCodigoCliente.Text == string.Empty || TxtNombreCliente.Text == string.Empty || TxtRncCliente.Text == string.Empty ||
                    TxtDireccionCliente.Text == string.Empty || MTxtTelefonoCliente.Text == string.Empty ||
                    TxtEmailCliente.Text == string.Empty||CbEstado.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe completa todos los campos", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Cliente.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text.Trim());
                    Cliente.Codigo = TxtCodigoCliente.Text.Trim();
                    Cliente.Nombre = TxtNombreCliente.Text.Trim();
                    Cliente.RNC_Cliente = TxtRncCliente.Text.Trim();
                    Cliente.Direccion = TxtDireccionCliente.Text.Trim();
                    Cliente.Telefono = MTxtTelefonoCliente.Text.Trim();
                    Cliente.Email = TxtEmailCliente.Text.Trim();
                    Cliente.Estado = CbEstado.Text.Trim();


                    Clientes.EditarCliente(Cliente);
                    MessageBox.Show("El Cliente fue Editado correctamente", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    this.Close();
                    Actualizar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente no fue editado por: " + ex.Message, "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
