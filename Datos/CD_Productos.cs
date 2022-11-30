using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidad;
using System.Windows.Forms;

namespace Datos
{
    public class CD_Productos
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Metodo que nos permite Agregar un producto a la base de datos
        public void AgregarProducto(CE_Productos Productos)
        {
            Cmd = new SqlCommand("AgregarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Decripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_venta", Productos.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Metodo que nos permite Editar un producto a la base de datos


        public void EditarProducto(CE_Productos Productos)
        {
            Cmd = new SqlCommand("EditarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Decripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_venta", Productos.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Productos.Id_Producto));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        //Metodo que nos permite Eliminar un producto a la base de datos

        public void EliminarProducto(CE_Productos Productos)
        {
            int Existencia =0;
            Cmd = new SqlCommand("Select Cantidad From Inventario Where Id_Inventario="+Productos.Id_Producto +"", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Existencia = Convert.ToInt32(Dr["Cantidad"].ToString());
            }

            Dr.Close();

            if(Existencia != 0)
            {
                MessageBox.Show("El Producto Contiene Existencias No Puede Ser Eliminado", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;            
            }
            else
            {
                Cmd = new SqlCommand("EliminarProducto", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Productos.Id_Producto));
                Cmd.ExecuteNonQuery();

                MessageBox.Show("El Producto fue Eliminado Correctamente", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

                Con.Cerrar();
            }
        }


        //Medoto que permite buscar por el codigo
        public DataTable Buscar_Producto_Codigo(CE_Productos Productos)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Producto_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }


        //Medoto que permite buscar por el Nombre

        public DataTable Buscar_Producto_Nombre(CE_Productos Productos)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Producto_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
        //Medoto que permite buscar por el descripcion
        public DataTable Buscar_Producto_Decripcion(CE_Productos Productos)
        {
            Dt = new DataTable("Decripcion");
            Cmd = new SqlCommand("Buscar_Producto_Decripcion", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
    }
}
