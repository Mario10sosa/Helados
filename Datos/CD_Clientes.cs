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
    public class CD_Clientes
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Metodo que nos permite Agregar un Cliente a la base de datos
        public void AgregarCliente(CE_Clientes Clientes)
        {
            Cmd = new SqlCommand("AgregarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Cliente", Clientes.RNC_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Clientes.Email));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Clientes.Estado));


            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Metodo que nos permite Editar un Cliente a la base de datos


        public void EditarCliente(CE_Clientes Clientes)
        {
            Cmd = new SqlCommand("EditarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Cliente", Clientes.RNC_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Clientes.Email));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Clientes.Estado));
            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", Clientes.Id_Cliente));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        //Metodo que nos permite Eliminar un Cliente a la base de datos

        public void EliminarCliente(CE_Clientes Clientes)
        {
            Cmd = new SqlCommand("EliminarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", Clientes.Id_Cliente));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }


        //Medoto que permite buscar por el codigo
        public DataTable Buscar_Cliente_Codigo(CE_Clientes Clientes)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Cliente_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }


        //Medoto que permite buscar por el Nombre

        public DataTable Buscar_Cliente_Nombre(CE_Clientes Clientes)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Cliente_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
        //Medoto que permite buscar por el descripcion
        public DataTable Buscar_Cliente_RNC_Cliente(CE_Clientes Clientes)
        {
            Dt = new DataTable("RNC_Cliente");
            Cmd = new SqlCommand("Buscar_Cliente_RNC_Cliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
    }
}
