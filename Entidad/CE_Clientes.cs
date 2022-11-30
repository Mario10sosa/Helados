using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CE_Clientes
    {
        private int _Id_Cliente;
        private string _Codigo;
        private string _Nombre;
        private string _RNC_Cliente;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Estado;
        private string _Buscar;

        public int Id_Cliente { get => _Id_Cliente; set => _Id_Cliente = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string RNC_Cliente { get => _RNC_Cliente; set => _RNC_Cliente = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
