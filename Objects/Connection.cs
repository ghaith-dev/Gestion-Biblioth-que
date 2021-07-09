using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gestion_Bibliothèque.Forms
{
    class Connection
    {
       
        
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Gestion Bib\Gestion Bibliothèque\Gestion Bibliothèque\Database\Database.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        
        public Connection() {

            conn.ConnectionString = locate;

        }
        public Boolean IUD(String SQL) {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL,conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
                
            }
            catch (SqlException exp) {
                MessageBox.Show(exp.ToString()) ;
                return false;
            }
            
            
        }
        public DataTable Select(String SQL) {
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL,conn);
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable DataTab = new DataTable();
            Adapter.Fill(DataTab);
            return DataTab;
            DataTab.Clear();
            
            
         
            
        }
       
    }
}
