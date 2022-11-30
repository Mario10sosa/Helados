using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;


namespace Dominio
{
    public class CDo_Proveedores
    {

        CD_Proveedores objProveedor = new CD_Proveedores();

        public void AgregarProvedor(CE_Proveedores Proveedores)
        {
            objProveedor.AgregarProvedor(Proveedores);
        }

        public void EditarProvedor(CE_Proveedores Proveedores)
        {
            objProveedor.EditarProvedor(Proveedores);
        }
        public void EliminarProvedor(CE_Proveedores Proveedores)
        {
            objProveedor.EliminarProvedor(Proveedores);
        }

        public DataTable Buscar_Provedor_Codigo(CE_Proveedores Proveedores)
        {
            return objProveedor.Buscar_Provedor_Codigo(Proveedores);
        }

        public DataTable Buscar_Provedor_Nombre(CE_Proveedores Proveedores)
        {
            return objProveedor.Buscar_Provedor_Nombre(Proveedores);
        }

        public DataTable Buscar_Provedor_RNC(CE_Proveedores Proveedores)
        {
            return objProveedor.Buscar_Provedor_RNC(Proveedores);
        }
    }
}
