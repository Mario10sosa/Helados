using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion_DB"].ConnectionString);

        //Metodo que permite la abrir la conexion a la base de datos

        public SqlConnection Abrir()
        {
            if(Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        //Metodo que permite la cerrar la conexion a la base de datos
        public SqlConnection Cerrar()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}

