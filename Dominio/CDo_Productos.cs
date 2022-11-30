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
    public class CDo_Productos
    {

        CD_Productos objProducto = new CD_Productos();

        public void AgregarProducto(CE_Productos Productos)
        {
            objProducto.AgregarProducto(Productos);
        }

        public void EditarProducto(CE_Productos Productos)
        {
            objProducto.EditarProducto(Productos);
        }
        public void EliminarProducto(CE_Productos Productos)
        {
            objProducto.EliminarProducto(Productos);
        }

        public DataTable Buscar_Producto_Codigo(CE_Productos Productos)
        {
           return objProducto.Buscar_Producto_Codigo(Productos);
        }

        public DataTable Buscar_Producto_Nombre(CE_Productos Productos)
        {
            return objProducto.Buscar_Producto_Nombre(Productos);
        }

        public DataTable Buscar_Producto_Decripcion(CE_Productos Productos)
        {
            return objProducto.Buscar_Producto_Decripcion(Productos);
        }


    }
}
