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
    public partial class FrmProductos : FrmBase
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        CDo_Procdimientos Procedimientos = new CDo_Procdimientos();
        CDo_Productos Productos = new CDo_Productos();
        CE_Productos Producto = new CE_Productos();
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DtProducto.Columns[0].Visible = false; //id producto

            DtProducto.Columns[1].Width = 140;//Codigo
            DtProducto.Columns[2].Width = 260;//Nombre Producto
            DtProducto.Columns[3].Width = 300;//Decripcion
            DtProducto.Columns[4].Width = 150;//presentacion
            DtProducto.Columns[5].Width = 140;//Costo unitario
            DtProducto.Columns[6].Width = 140;//precio de venta
            DtProducto.Columns[7].Width = 150;//Tipo de cargo

            DtProducto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProducto.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtProducto.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtProducto.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProducto.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            DtProducto.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaGridView(DtProducto);
        }

        private void CargarDatos()
        {
            DtProducto.DataSource = Procedimientos.CargarDatos("Productos");
            DtProducto.ClearSelection();
        }
        private void AgPro_UpdateEventHandler(object sender,FrmAgregarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto AgregarProducto = new FrmAgregarProducto(this);
            AgregarProducto.UpdateEventHandler += AgPro_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(DtProducto.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if(DtProducto.SelectedRows == null)
                {
                    return;
                }
                else
                {

                    try
                    {
                        FrmEditarProducto EditarProductos = new FrmEditarProducto(this);
                        EditarProductos.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarProductos.TxtIdProducto.Text = DtProducto.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProductos.TxtCodigo.Text = DtProducto.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProductos.TxtNombre.Text = DtProducto.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProductos.TxtDescripcion.Text = DtProducto.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProductos.TxtPresentacion.Text = DtProducto.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProductos.TxtCostoUnitario.Text = DtProducto.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProductos.TxtPrecioVenta.Text = DtProducto.SelectedRows[0].Cells[6].Value.ToString();
                        EditarProductos.CbTipoCargo.Text = DtProducto.SelectedRows[0].Cells[7].Value.ToString();

                        EditarProductos.ShowDialog();
                    }
                    catch(Exception ex)
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
            if(DtProducto.Rows.Count ==0)
            {
                MessageBox.Show("No hay registro para Eliminar","Eliminar Producto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(DtProducto.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta seguro que desea eliminar este producto", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(Resultados == DialogResult.Yes)
                        {
                            Producto.Id_Producto = Convert.ToInt32(DtProducto.SelectedRows[0].Cells[0].Value.ToString());
                            Productos.EliminarProducto(Producto);
                            CargarDatos();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un registro para Eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void TxtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
        {
            try
            {
                if(CBTipoBusqueda.Text == "Codigo")
                {
                    Producto.Buscar = TxtBuscarProductos.Text.Trim();
                    DtProducto.DataSource = Productos.Buscar_Producto_Codigo(Producto);

                }
                else if(CBTipoBusqueda.Text =="Nombre")
                {
                    Producto.Buscar = TxtBuscarProductos.Text.Trim();
                    DtProducto.DataSource = Productos.Buscar_Producto_Nombre(Producto);
                }
                else if (CBTipoBusqueda.Text == "Decripcion")
                {
                    Producto.Buscar = TxtBuscarProductos.Text.Trim();
                    DtProducto.DataSource = Productos.Buscar_Producto_Decripcion(Producto);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("El Producto no fue encontrado por: " + ex.Message, "Buscar Producto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
