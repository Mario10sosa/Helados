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
    public partial class FrmEditarProveedor : FrmBase
    {
        public FrmEditarProveedor(FrmProveedores Proveedores)
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Proveedores Proveedores = new CDo_Proveedores();
        CE_Proveedores Proveedor = new CE_Proveedores();

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

        private void FrmEditarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtRncProveedor.Focus();
                e.Handled = true;
            }
        }

        private void TxtRncProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDireccionProveedor.Focus();
                e.Handled = true;
            }
        }

        private void TxtDireccionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MTxtTelefonoProveedor.Focus();
                e.Handled = true;
            }
        }

        private void MTxtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtEmailProveedor.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmailProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnEditarProveedor.Focus();
                e.Handled = true;
            }
        }

        private void BtnEditarProveedor_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try
            {
                if (TxtCodigoProveedor.Text == string.Empty || TxtNombreProveedor.Text == string.Empty || TxtRncProveedor.Text == string.Empty ||
                    TxtDireccionProveedor.Text == string.Empty || MTxtTelefonoProveedor.Text == string.Empty ||
                    TxtEmailProveedor.Text == string.Empty )
                {
                    MessageBox.Show("Por Favor Debe completa todos los campos", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Proveedor.Id_Proveedor = Convert.ToInt32(TxtIdProveedor.Text.Trim());
                    Proveedor.Codigo = TxtCodigoProveedor.Text.Trim();
                    Proveedor.Nombre = TxtNombreProveedor.Text.Trim();
                    Proveedor.RNC_Proveedor = TxtRncProveedor.Text.Trim();
                    Proveedor.Direccion = TxtDireccionProveedor.Text.Trim();
                    Proveedor.Telefono = MTxtTelefonoProveedor.Text.Trim();
                    Proveedor.Email = TxtEmailProveedor.Text.Trim();
                   

                    Proveedores.EditarProvedor(Proveedor);
                    MessageBox.Show("El Proveedor fue Editado correctamente", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    this.Close();
                    Actualizar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Proveedor no fue editado por: " + ex.Message, "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
