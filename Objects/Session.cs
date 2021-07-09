using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Bibliothèque.Forms;

namespace Gestion_Bibliothèque.Objects
{
    class Session
    {
        private int ID;
        private String User;
        private String Password;
        Connection Con = new Connection();
        public Session( int ID,String User,String Password) {
            this.ID = ID;
            this.User = User;
            this.Password = Password;
            

        }
        public Boolean Ajouter(Session s) {
            try
            {
                Con.IUD("INSERT INTO Login(Username,Password) VALUES('" + s.User + "','" + s.Password + "') ");
                return true;
            }
            catch (SqlException exp) {
                return false;

            }
        }
       public Boolean Modifier(Session s) {
            try
            {
                Con.IUD("UPDATE  Login SET Username='"+s.User+"',Password='"+s.Password+"'WHERE Id='"+this.ID+"'");
                return true;
            }
            catch (SqlException exp)
            {
                return false;

            }
        }
        public Boolean Supprimer(Session s) {
            try
            {
                Con.IUD("DELETE FROM  Login  WHERE Id='" + this.ID + "'");
                return true;
            }
            catch (SqlException exp)
            {
                return false;

            }
        }
        public Boolean Connecter() {
            try
            {
                
                
               DataTable dt= Con.Select("SELECT * FROM Login WHERE Username='" + User + "'AND Password='" + Password + "'");
                if (dt.Rows.Count >= 1) {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (SqlException e) {
                MessageBox.Show(e.ToString());
                return false;
            }
                }

        }
}
