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
    public partial class FrmAgregarCliente : FrmBase
    {
        public FrmAgregarCliente(FrmClientes Clientes)
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

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void Frm_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            TxtCodigoCliente.Text = "PRO" + Procedimientos.GenerarCodigo("Clientes");
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
                BtnAgregar.Focus();
                e.Handled = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try
            {
                if (TxtCodigoCliente.Text == string.Empty || TxtNombreCliente.Text == string.Empty || TxtRncCliente.Text == string.Empty ||
                    TxtDireccionCliente.Text == string.Empty || MTxtTelefonoCliente.Text == string.Empty ||
                    TxtEmailCliente.Text == string.Empty||CbEstado.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe completa todos los campos", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Cliente.Codigo = TxtCodigoCliente.Text.Trim();
                    Cliente.Nombre = TxtNombreCliente.Text.Trim();
                    Cliente.RNC_Cliente = TxtRncCliente.Text.Trim();
                    Cliente.Direccion = TxtDireccionCliente.Text.Trim();
                    Cliente.Telefono = MTxtTelefonoCliente.Text.Trim();
                    Cliente.Email = TxtEmailCliente.Text.Trim();
                    Cliente.Estado = CbEstado.Text.Trim();

                    Clientes.AgregarCliente(Cliente);
                    MessageBox.Show("El Cliente fue agregado correctamente", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    GenerarCodigo();
                    TxtNombreCliente.Focus();
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente no fue agregado por: " + ex.Message, "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
