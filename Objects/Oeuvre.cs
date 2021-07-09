using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Bibliothèque.Forms;

namespace Gestion_Bibliothèque.Objects
{
    class Oeuvre
    {
        public int Id;
        public String Titre;
        public String Auteur;
        public int NbrExemplaire;
        public String DateDeRéa;
        public int CDAB;
        Connection cnx = new Connection();
        public Oeuvre(int Id,String Titre, String Auteur, int NbrExemplaire, String DateDeRéa, int CDAB) {
            this.Id = Id;
            this.Titre = Titre;
            this.Auteur = Auteur;
            this.NbrExemplaire = NbrExemplaire;
            this.DateDeRéa = DateDeRéa;
            this.CDAB = CDAB;
        }
        public Boolean Ajouter(Oeuvre oeuvre) { 
            try
            {
                
                cnx.IUD("INSERT INTO Oeuvre (Titre,Auteur,NbrExemplaire,DateDeRéa,CDAB) VALUES ('" + oeuvre.Titre + "','" + oeuvre.Auteur + "','" + oeuvre.NbrExemplaire + "','" + oeuvre.DateDeRéa + "','" + oeuvre.CDAB + "')");
                return true;  
            }
            catch (SqlException exp) {
                return false;
            }
            
        }
        public Boolean Modifier( Oeuvre oeuvre)
        {
            try
            {
                
                cnx.IUD("UPDATE Oeuvre SET Titre='" + oeuvre.Titre + "',Auteur='" + oeuvre.Auteur + "',NbrExemplaire='" + oeuvre.NbrExemplaire + "',DateDeRéa='" + oeuvre.DateDeRéa + "',CDAB='" + oeuvre.CDAB + "' WHERE Id='"+ oeuvre.Id+ "'");
                return true;
            }
            catch (SqlException exp)
            {
                return false;
            }

        }
        public Boolean Supprimer(Oeuvre oeuvre)
        {
            try
            {
                
                cnx.IUD("DELETE FROM Oeuvre  WHERE Id='" + oeuvre.Id + "'");
                return true;
            }
            catch (SqlException exp)
            {
                return false;
            }

        }
        public Boolean Decrémenter(Oeuvre oeuvre)
        {
            try
            {
                
                DataTable dt = cnx.Select("SELECT NbrExemplaire FROM Oeuvre WHERE Id='" + oeuvre.Id + "' ");
                int nbrOeuvre = Convert.ToInt32( dt.Rows[0][0].ToString())-1;
               cnx.IUD("UPDATE Oeuvre SET NbrExemplaire='"+nbrOeuvre+"' WHERE Id='" + oeuvre.Id+ "'");

                return true;
            }
            catch (SqlException exp)
            {
                return false;
            }


        }
        public Boolean Incrémenter(Oeuvre oeuvre)
        {
            try
            {
                DataTable dt = cnx.Select("SELECT NbrExemplaire FROM Oeuvre WHERE Id='" + oeuvre.Id + "' ");
                int nbrOeuvre = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                cnx.IUD("UPDATE Oeuvre SET NbrExemplaire='" + nbrOeuvre + "' WHERE Id='" + oeuvre.Id + "'");

                return true;
            }
            catch (SqlException exp)
            {
                return false;
            }


        }
        public int getId()
        {
            return this.Id;
        }
        public Boolean isDisponible(Oeuvre oeuvre)
        {
            

                DataTable dt = cnx.Select("SELECT NbrExemplaire FROM Oeuvre WHERE Id='" + oeuvre.Id + "' ");
                if( Convert.ToInt32(dt.Rows[0][0].ToString())>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                

                
            
            


        }
    }
   
}
