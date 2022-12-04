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
    public class CD_Ingreso_Productos
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;


        public void AgregarIngreso(CE_Ingreso_Productos Ingresos)
        {
            Cmd = new SqlCommand("Agregar_Ingreso_Productos",Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@No_Ingreso", Ingresos.No_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Ingresos.Id_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", Ingresos.Fecha_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Comprobate", Ingresos.Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ingresos.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Ingresos.Estado));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public void AnularProductos(CE_Ingreso_Productos Ingresos)
        {
            Cmd = new SqlCommand("Anular_Ingreso_Productos", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Ingresos.Id_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Ingresos.Id_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", Ingresos.Fecha_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Comprobate", Ingresos.Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ingresos.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Ingresos.Estado));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public DataTable MostrarIngresoProductos()
        {
            DataTable Dt= new DataTable("Ingreso_Productos");
            Cmd = new SqlCommand("Mostrar_Ingreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr= Cmd.ExecuteReader();
            Dt.Load(Dr);

            Con.Cerrar();
            return Dt;
        }

    }
}
