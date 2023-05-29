using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class Conexion
    {
        SqlConnection cnx;

        public Conexion()
        {
            try
            {
                //cnx = new SqlConnection("Data Source=DESKTOP-3LP6553\\SQLEXPRESS;Initial Catalog=bazar_v2");
                cnx = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = bazar_v2; Data Source = DESKTOP-3LP6553\\SQLEXPRESS");
                cnx.Open();
                MessageBox.Show("conectado correctamente", "conexion exitosa", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error al conectar con la base de datos", MessageBoxButtons.OK);

            }
        }
    }
}