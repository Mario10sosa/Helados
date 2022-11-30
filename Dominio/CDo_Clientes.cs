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
    public class CDo_Clientes
    {
        CD_Clientes objClientes = new CD_Clientes();

        public void AgregarCliente(CE_Clientes Clientes)
        {
            objClientes.AgregarCliente(Clientes);
        }

        public void EditarCliente(CE_Clientes Clientes)
        {
            objClientes.EditarCliente(Clientes);
        }
        public void EliminarCliente(CE_Clientes Clientes)
        {
            objClientes.EliminarCliente(Clientes);
        }

        public DataTable Buscar_Cliente_Codigo(CE_Clientes Clientes)
        {
            return objClientes.Buscar_Cliente_Codigo(Clientes);
        }

        public DataTable Buscar_Cliente_Nombre(CE_Clientes Clientes)
        {
            return objClientes.Buscar_Cliente_Nombre(Clientes);
        }

        public DataTable Buscar_Cliente_RNC_Cliente(CE_Clientes Clientes)
        {
            return objClientes.Buscar_Cliente_RNC_Cliente(Clientes);
        }
    }
}
