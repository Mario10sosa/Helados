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
    public class CDo_Empresas
    {
        CD_Empresas objEmpresas = new CD_Empresas();

        public void AgregarEmpresa(CE_Empresas Empresas)
        {
            objEmpresas.AgregarEmpresa(Empresas);
        }

        public void EditarEmpresa(CE_Empresas Empresas)
        {
            objEmpresas.EditarEmpresa(Empresas);
        }
        public void EliminarEmpresa(CE_Empresas Empresas)
        {
            objEmpresas.EliminarEmpresa(Empresas);
        }
    }
}
