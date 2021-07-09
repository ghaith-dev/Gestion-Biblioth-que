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
    class Adhérent
    {
        private int Id;
        private String Nom;
        private String Prénom;
        private int Age;
        private int CIN;
        private int Tél;
        Connection con = new Connection();
        public Adhérent(int Id,String Nom , String Prénom,int Age,int CIN ,int Tél)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Prénom = Prénom;
            this.Age = Age;
            this.CIN = CIN;
            this.Tél = Tél;
            
        }

        public Boolean Ajouter(Adhérent adhérent)
        {
            try {
                con.IUD("INSERT INTO  Adhérent (Nom,Prénom,Age,CIN,Tel)  VALUES('" + adhérent.Nom + "','" + adhérent.Prénom + "','" + adhérent.Age + "','" + adhérent.CIN + "','" + adhérent.Tél + "')");
                return true;
            } catch(SqlException) { return false;
            }
            
        }
        public Boolean Modifier(Adhérent adhérent)
        {
            try
            {
                con.IUD("UPDATE  Adhérent SET Nom='" + adhérent.Nom + "',Prénom='" + adhérent.Prénom + "',Age='" + adhérent.Age + "',CIN='" + adhérent.CIN + "',Tel='" + adhérent.Tél + "' WHERE Id='" + adhérent.Id + "' ");

                return true;
            }
            catch (SqlException)
            {

                return false;
            }
        } 
        public Boolean Supprimer(Adhérent adhérent)
        {
            try
            {
            con.IUD("DELETE FROM  Adhérent  WHERE Id='" + adhérent.Id + "' ");
            return true;
            }
            catch (SqlException)
            {
                return false;
            }
            
        }
        public int  getId()
        {
            return this.Id;
        }
    }
}
