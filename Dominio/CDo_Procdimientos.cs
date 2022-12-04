using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dominio
{
    public class CDo_Procdimientos
    {
        CD_Procedimiento ObjProcedimiento = new CD_Procedimiento();

        //Metodo que permite cargar los datos de una tabla a un dataGridview

        public DataTable CargarDatos(string Tabla)
        {
            return ObjProcedimiento.CargarDatos(Tabla);
        }

        //Metodo que permite alternar los colores en las fila de un dataGridview

        public void AlternarColorFilaGridView(DataGridView Dgv)
        {
            ObjProcedimiento.AlternarColorFilaGridView(Dgv);
        }

        //Metodo que permite cargar los datos de una tabla a un dataGridview

        public string GenerarCodigo(string Tabla)
        {
            return ObjProcedimiento.GenerarCodigo(Tabla);
        }

        //Metodo que permite cargar los datos de una tabla a un dataGridview

        public string GenerarCodigoId(string Tabla)
        {

            
            return ObjProcedimiento.GenerarCodigoId(Tabla);
        }

        //Metodo que permite dar formulario moneda a un textbox o caja de texto
        public void FormatoMoneda(TextBox xTBox)
        {
            ObjProcedimiento.FormatoMoneda(xTBox);
        }

        //Metodo que permite dar formulario moneda a un textbox o caja de texto
        public void LimpiarControles(Form xForm)
        {
            ObjProcedimiento.LimpiarControles(xForm);
        }

        //Metodo que permite dar formulario moneda a un textbox o caja de texto
        public void LlenarCombox(string Tabla, string Nombre, ComboBox xCBox)
        {
            ObjProcedimiento.LlenarCombox(Tabla, Nombre, xCBox);
        }
    }
}
