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
    public partial class FrmAgregarIngresoProducto : FrmBase
    {
        public FrmAgregarIngresoProducto(FrmCompras Compras)
        {
            InitializeComponent();
        }

        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_IngresoProductos Ingresos = new CDo_IngresoProductos();
        CE_Ingreso_Productos Ingreso = new CE_Ingreso_Productos();
        CDo_Detalle_Ingresos DetalleIngresos = new CDo_Detalle_Ingresos();
        CE_Detalle_Ingresos DetalleIngreso = new CE_Detalle_Ingresos();

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
        private void FrmAgregarIngresoProducto_Load(object sender, EventArgs e)
        {
            MejorVista();
            TxtTotal_Pago.Text = "0.00";
            Correlativo();
        }

        private void MejorVista()
        {

            DtIngreso_Producto.Columns[0].Visible = false;// Id Producto

            DtIngreso_Producto.Columns[1].Width = 300;//nombre Producto
            DtIngreso_Producto.Columns[2].Width = 160;// cantidad
            DtIngreso_Producto.Columns[3].Width = 160;// Costo Unitario
            DtIngreso_Producto.Columns[4].Width = 160;// sub total

            DtIngreso_Producto.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtIngreso_Producto.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtIngreso_Producto.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Procedimientos.AlternarColorFilaGridView(DtIngreso_Producto);
        }

        private void Correlativo()
        {
            TxtId_Ingreso.Text = Procedimientos.GenerarCodigoId("Ingreso_Productos");
            TxtNo_Ingreso.Text = Procedimientos.GenerarCodigo("Ingreso_Productos");
            TxtId_Detalle.Text = Procedimientos.GenerarCodigoId("Detalle_Ingreso");
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedores vistaProveedores = new FrmVistaProveedores();
            vistaProveedores.ShowDialog();

            try
            {
                if (vistaProveedores.DialogResult == DialogResult.OK)
                {
                    TxtId_Proveedor.Text = vistaProveedores.DtVistaProveedor.Rows[vistaProveedores.DtVistaProveedor.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtNombreProveedor.Text = vistaProveedores.DtVistaProveedor.Rows[vistaProveedores.DtVistaProveedor.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtComprobante.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Seleccionar un proveedor en la lista Proveedor", "Selecionar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        public static int Contfila = 0;
        public static decimal Total;

        private void AgregarDetalle()
        {
            decimal SubTotal = 0;

            try
            {
                if (TxtId_Producto.Text == string.Empty || TxtNomProducto.Text == string.Empty || TxtCantidad.Text == string.Empty || TxtCantidad.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar todos los Campos del detalles ingreso", "Agregar Detalle Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    bool Existe = false;
                    int No_Fila = 0;

                    if (Contfila == 0)
                    {
                        SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCosto_Unitario.Text);

                        DtIngreso_Producto.Rows.Add(TxtId_Producto.Text, TxtNomProducto.Text, TxtCantidad.Text, TxtCosto_Unitario.Text, SubTotal.ToString("N2"));

                        DtIngreso_Producto.ClearSelection();
                        LimpiarDetalle();
                        BtnAgregarProducto.Focus();

                        Contfila++;
                    }
                    else
                    {
                        foreach (DataGridViewRow row in DtIngreso_Producto.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == TxtId_Producto.Text)
                            {
                                Existe = true;
                                No_Fila = row.Index;
                            }

                        }

                        if (Existe == true)
                        {
                            SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCosto_Unitario.Text);
                            DtIngreso_Producto.Rows[No_Fila].Cells[2].Value = Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(DtIngreso_Producto.Rows[No_Fila].Cells[2].Value.ToString());
                            DtIngreso_Producto.Rows[No_Fila].Cells[4].Value = (SubTotal + Convert.ToDecimal(DtIngreso_Producto.Rows[No_Fila].Cells[4].Value)).ToString("N2");
                            LimpiarDetalle();
                        }
                        else
                        {
                            SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCosto_Unitario.Text);

                            DtIngreso_Producto.Rows.Add(TxtId_Producto.Text, TxtNomProducto.Text, TxtCantidad.Text, TxtCosto_Unitario.Text, SubTotal.ToString("N2"));

                            DtIngreso_Producto.ClearSelection();
                            LimpiarDetalle();
                            BtnAgregarProducto.Focus();

                            Contfila++;
                        }
                       
                    }
                    Total = 0;
                    foreach (DataGridViewRow row in DtIngreso_Producto.Rows)
                    {
                        Total += Convert.ToDecimal(row.Cells[4].Value);
                    }
                    TxtTotal_Pago.Text = Total.ToString("N2");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El producto no fue agregado por: "+ ex.Message,"Agrehar Producto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

         
        }

        private void LimpiarDetalle()
        {
            TxtId_Producto.Text = string.Empty;
            TxtCodigo_Producto.Text = string.Empty;
            TxtNomProducto.Text = string.Empty;
            TxtCosto_Unitario.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtCodigo_Producto.Focus();

        }

        private void BtnBuscar_Producto_Click(object sender, EventArgs e)
        {

            FrmVistaProductos vistaProductos = new FrmVistaProductos();
            vistaProductos.ShowDialog();

            try
            {
                if (vistaProductos.DialogResult == DialogResult.OK)
                {
                    TxtId_Producto.Text = vistaProductos.DtVistaProductos.Rows[vistaProductos.DtVistaProductos.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtCodigo_Producto.Text = vistaProductos.DtVistaProductos.Rows[vistaProductos.DtVistaProductos.CurrentRow.Index].Cells[1].Value.ToString();
                    TxtNomProducto.Text = vistaProductos.DtVistaProductos.Rows[vistaProductos.DtVistaProductos.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtCosto_Unitario.Text = vistaProductos.DtVistaProductos.Rows[vistaProductos.DtVistaProductos.CurrentRow.Index].Cells[5].Value.ToString();

                    TxtCantidad.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Seleccionar un producto en la lista Producto", "Selecionar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Contfila > 0)
                {
                    Total = Total - Convert.ToDecimal(DtIngreso_Producto.Rows[DtIngreso_Producto.CurrentRow.Index].Cells[4].Value);
                    TxtTotal_Pago.Text = Total.ToString("N2");

                    DtIngreso_Producto.Rows.RemoveAt(DtIngreso_Producto.CurrentRow.Index);
                    Contfila--;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay fila para eliminar","Eliminar fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void TxtComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnBuscar_Producto.Focus();
                e.Handled = true;
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnAgregarProducto.Focus();
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
                if (TxtId_Ingreso.Text == string.Empty|| TxtNo_Ingreso.Text == string.Empty || TxtId_Proveedor.Text == string.Empty ||
                    TxtNombreProveedor.Text == string.Empty || TxtComprobante.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar todos los campos por favor", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Ingreso.No_Ingreso = TxtNo_Ingreso.Text.Trim();
                    Ingreso.Id_Proveedor = Convert.ToInt32(TxtId_Proveedor.Text.Trim());
                    Ingreso.Fecha_Ingreso = Convert.ToDateTime(DtpFecha_Ingreso.Text.Trim());
                    Ingreso.Comprobante = TxtComprobante.Text.Trim();
                    Ingreso.Monto_Total = Convert.ToDecimal(TxtTotal_Pago.Text.Trim());
                    Ingreso.Estado = "Emitido";

                    foreach(DataGridViewRow row in DtIngreso_Producto.Rows)
                    {
                        DetalleIngreso.Id_Ingreso = Convert.ToInt32(TxtId_Ingreso.Text);
                        DetalleIngreso.Id_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
                        DetalleIngreso.Nombre = Convert.ToString(row.Cells[1].Value.ToString());
                        DetalleIngreso.Cantidad = Convert.ToInt32(row.Cells[2].Value.ToString());
                        DetalleIngreso.Costo_Unitario = Convert.ToDecimal(row.Cells[3].Value.ToString());
                        DetalleIngreso.Sub_Total = Convert.ToDecimal(row.Cells[4].Value.ToString());

                        DetalleIngresos.AgregarDetalleIngreso(DetalleIngreso);

                    }

                    Ingresos.AgregarIngreso(Ingreso);

                    MessageBox.Show("Ingreso de productos agregado correctamente", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    TxtId_Detalle.Text = string.Empty;
                    TxtTotal_Pago.Text = "0.00";
                    Agregar();
                    LimpiarDetalle();
                    Correlativo();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El ingreso de productos no fue agregado por: " + ex.Message, "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
