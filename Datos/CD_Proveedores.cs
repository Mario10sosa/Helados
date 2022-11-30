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
    public class CD_Proveedores
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Metodo que nos permite Agregar un proveedor a la base de datos
        public void AgregarProvedor(CE_Proveedores Proveedores)
        {
            Cmd = new SqlCommand("AgregarProvedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Provedor", Proveedores.RNC_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Proveedores.Email));
            
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Metodo que nos permite Editar un proveedor a la base de datos


        public void EditarProvedor(CE_Proveedores Proveedores)
        {
            Cmd = new SqlCommand("EditarProvedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Provedor", Proveedores.RNC_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Proveedores.Email));
            Cmd.Parameters.Add(new SqlParameter("@Id_Provedor", Proveedores.Id_Proveedor));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        //Metodo que nos permite Eliminar un producto a la base de datos

        public void EliminarProvedor(CE_Proveedores Proveedores)
        { 
            Cmd = new SqlCommand("EliminarProvedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Provedor", Proveedores.Id_Proveedor));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
            
        }


        //Medoto que permite buscar por el codigo
        public DataTable Buscar_Provedor_Codigo(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Provedor_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }


        //Medoto que permite buscar por el Nombre

        public DataTable Buscar_Provedor_Nombre(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Provedor_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
        //Medoto que permite buscar por el descripcion
        public DataTable Buscar_Provedor_RNC(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("RNC_Proveedor");
            Cmd = new SqlCommand("Buscar_Provedor_RNC", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
    }
}
