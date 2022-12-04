using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Dominio
{
    public class CDo_IngresoProductos
    {
        CD_Ingreso_Productos objIngresoProducto = new CD_Ingreso_Productos();

        public void AgregarIngreso(CE_Ingreso_Productos Ingresos)
        {
            objIngresoProducto.AgregarIngreso(Ingresos);
        }

        public void AnularProductos(CE_Ingreso_Productos Ingresos)
        {
            objIngresoProducto.AnularProductos(Ingresos);
        }

        public DataTable MostrarIngresoProductos()
        {
            return objIngresoProducto.MostrarIngresoProductos();
        }

    }
}
