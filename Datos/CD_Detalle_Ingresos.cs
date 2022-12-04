using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidad;
using System.Windows.Forms;
using System.Drawing;

namespace Datos
{
    public class CD_Detalle_Ingresos
    {

        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;
        public void AgregarDetalleIngreso(CE_Detalle_Ingresos Detalles)
        {
            Cmd = new SqlCommand("Agregar_Detalle_Ingreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Detalles.Id_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalles.Id_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Detalles.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalles.Cantidad));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Detalles.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalles.Sub_Total));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public void AnularDetalleProductos(CE_Detalle_Ingresos Detalles)
        {
            Cmd = new SqlCommand("Anular_Detalle_Ingreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Detalles.Id_Detalle));
            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Detalles.Id_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalles.Id_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Detalles.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalles.Cantidad));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Detalles.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalles.Sub_Total));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
    }
}
