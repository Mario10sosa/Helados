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
    public class CD_Empresas
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Metodo que nos permite Agregar un Empresas a la base de datos
        public void AgregarEmpresa(CE_Empresas Empresas)
        {
            Cmd = new SqlCommand("AgregarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Empresas.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Empresa", Empresas.RNC_Empresa));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Empresas.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Empresas.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Empresas.Email));
          
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Metodo que nos permite Editar un Empresas a la base de datos


        public void EditarEmpresa(CE_Empresas Empresas)
        {
            Cmd = new SqlCommand("EditarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Nombre", Empresas.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Empresa", Empresas.RNC_Empresa));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Empresas.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Empresas.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Empresas.Email));
            Cmd.Parameters.Add(new SqlParameter("@Id_Empresa", Empresas.Id_Empresa));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        //Metodo que nos permite Eliminar un Empresas a la base de datos

        public void EliminarEmpresa(CE_Empresas Empresas)
        {
            Cmd = new SqlCommand("EliminarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Empresa", Empresas.Id_Empresa));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }
    }
}
