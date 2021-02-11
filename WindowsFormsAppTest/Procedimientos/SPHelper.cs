using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsAppTest.Clases;
using System.Windows.Forms;

namespace WindowsFormsAppTest.Procedimientos
{
    public static class SPHelper
    {
        
        internal static void InsertarUsuario(Usuario user)
        {
            string connString = "Data Source=DESKTOP-JHIV6FPK;Initial Catalog=test_db;Integrated Security=True;";
            SqlConnection connSQL = new SqlConnection(connString);
            try
            {
                connSQL.Open();

                SqlCommand cmdProcedimiento = new SqlCommand("InsertarUsuario", connSQL)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdProcedimiento.Parameters.AddWithValue("nombre", user.Nombre);
                cmdProcedimiento.Parameters.AddWithValue("email", user.Email);
                cmdProcedimiento.Parameters.AddWithValue("password", user.Password);

                cmdProcedimiento.ExecuteNonQuery();
                MessageBox.Show("Usuario Creado ");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Usuario No Creado " + sqlEx);
            }
            finally
            {
                connSQL.Close();
            }
        }
    }
}
