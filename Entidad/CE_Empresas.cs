using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CE_Empresas
    {
        private int _Id_Empresa;
        private string _Nombre;
        private string _RNC_Empresa;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Buscar;

        public int Id_Empresa { get => _Id_Empresa; set => _Id_Empresa = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string RNC_Empresa { get => _RNC_Empresa; set => _RNC_Empresa = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
