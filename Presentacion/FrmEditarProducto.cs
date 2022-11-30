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
    public partial class FrmEditarProducto : FrmBase
    {
        public FrmEditarProducto(FrmProductos Productos)
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Productos Productos = new CDo_Productos();
        CE_Productos Producto = new CE_Productos();

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

        private void FrmEditar_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDescripcion.Focus();
                e.Handled = true;
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPresentacion.Focus();
                e.Handled = true;
            }
        }

        private void TxtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtCostoUnitario.Focus();
                e.Handled = true;
            }
        }

        private void TxtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPrecioVenta.Focus();
                e.Handled = true;
            }
        }

        private void TxtCostoUnitario_Leave(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(TxtCostoUnitario);
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CbTipoCargo.Focus();
                e.Handled = true;
            }
        }

        private void TxtPrecioVenta_Leave(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(TxtPrecioVenta);
        }

        private void CbTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TxtCodigo.Text == string.Empty || TxtNombre.Text == string.Empty || TxtPresentacion.Text == string.Empty ||
                    TxtDescripcion.Text == string.Empty || TxtPrecioVenta.Text == string.Empty ||
                    TxtCostoUnitario.Text == string.Empty || TxtPrecioVenta.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe completa todos los campos", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Producto.Id_Producto = Convert.ToInt32(TxtIdProducto.Text.Trim());
                    Producto.Codigo = TxtCodigo.Text.Trim();
                    Producto.Nombre = TxtNombre.Text.Trim();
                    Producto.Descripcion = TxtDescripcion.Text.Trim();
                    Producto.Presentacion = TxtPresentacion.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(TxtCostoUnitario.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(TxtPrecioVenta.Text.Trim());
                    Producto.Tipo_Cargo = CbTipoCargo.Text.Trim();

                    Productos.EditarProducto(Producto);
                    MessageBox.Show("El producto fue Editado correctamente", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    this.Close();
                    Actualizar();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue editado por: " + ex.Message, "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
