using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Datos
{
    public class CD_Procedimiento
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataReader Dr;
        DataTable Dt;

        //Metodo que permite cargar los datos de una tabla a un dataGridview

        public DataTable CargarDatos(string Tabla)
        {
            Dt = new DataTable("Cargar_Datos");
            Cmd = new SqlCommand("Select  * From "+Tabla,Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);
            Dr.Close();

            Con.Cerrar();
            return Dt;
        }

        //Metodo que permite alternar los colores en las fila de un dataGridview

        public void AlternarColorFilaGridView(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }

        //Metodo que permite cargar los datos de una tabla a un dataGridview

        public string GenerarCodigo(string Tabla)
        {

            string codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select Count(*) as TotalRegistros From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Total = Convert.ToInt32(Dr["TotalRegistros"]) + 1;
            }
            Dr.Close();
            if(Total < 10)
            {
                codigo = "0000000" + Total;
            }
            else if (Total < 100)
            {
                codigo = "000000" + Total;
            }
            else if (Total < 1000)
            {
                codigo = "00000" + Total;
            }
            else if (Total < 10000)
            {
                codigo = "0000" + Total;
            }
            else if (Total < 100000)
            {
                codigo = "000" + Total;
            }
            else if (Total < 1000000)
            {
                codigo = "00" + Total;
            }
            else if (Total < 10000000)
            {
                codigo = "0" + Total;
            }


            Con.Cerrar();
            return codigo;
        }

        //Metodo que permite cargar los datos de una tabla a un dataGridview

        public string GenerarCodigoId(string Tabla)
        {

            string codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select Count(*) as TotalRegistros From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Total = Convert.ToInt32(Dr[" TotalRegistros"]) + 1;
            }
            Dr.Close();
           


            Con.Cerrar();
            return codigo;
        }

        //Metodo que permite dar formulario moneda a un textbox o caja de texto
        public void FormatoMoneda(TextBox xTBox)
        {
            if(xTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;
                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");
            }
        }

        //Metodo que permite dar formulario moneda a un textbox o caja de texto
        public void LimpiarControles(Form xForm)
        {
           foreach(var xCtrl in xForm.Controls)
            {
                if(xCtrl is TextBox)
                {
                    ((TextBox)xCtrl).Text = String.Empty;

                }
                else if (xCtrl is ComboBox)
                {
                    ((ComboBox)xCtrl).Text = String.Empty;

                }
            }
        }

        //Metodo que permite dar formulario moneda a un textbox o caja de texto
        public void LlenarCombox(string Tabla, string Nombre, ComboBox xCBox)
        {
            Cmd = new SqlCommand("Select * From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                xCBox.Items.Add(Dr[Nombre].ToString());
            }
        }

    }
}
