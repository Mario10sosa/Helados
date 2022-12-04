using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Dominio
{
    public class CDo_Detalle_Ingresos
    {
        CD_Detalle_Ingresos objDetalleIngresos = new CD_Detalle_Ingresos();

        public void AgregarDetalleIngreso(CE_Detalle_Ingresos Detalles)
        {
            objDetalleIngresos.AgregarDetalleIngreso(Detalles);
        }

        public void AnularDetalleProductos(CE_Detalle_Ingresos Detalles)
        {
            objDetalleIngresos.AnularDetalleProductos(Detalles);
        }
    }
}
