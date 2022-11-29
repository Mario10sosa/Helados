using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidad;

namespace Datos
{
    public class CD_Productos
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;

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
            Cmd = new SqlCommand("EliminarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Productos.Id_Producto));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

    }
}
