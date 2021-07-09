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
    class Pret
    {
        Connection con = new Connection();
        private int id;
        private int idAdhé;
        private int idOeuvre;
        public Pret(int id, Adhérent adhérent, Oeuvre oeuvre) {
            this.id = id;
            this.idAdhé = adhérent.getId();
            this.idOeuvre = oeuvre.getId();
        }
        public Boolean EffectuerPret(Pret pret) {
            try
            {
                con.IUD("INSERT INTO Pret(IdAdhé,IdOeuvre)VALUES('" + pret.idAdhé + "','" + pret.idOeuvre + "')");


                return true;
            }
            catch (SqlException exp ) {
                return false;
            }


        }
        public Boolean ModifierPret(Pret pret)
        {
            try
            {
                con.IUD("UPDATE  Pret SET IdAdhé='" + pret.idAdhé + "',IdOeuvre='" + pret.idOeuvre + "' WHERE Id='"+pret.id+"' ");

                return true;
            }
            catch (SqlException exp)
            {
                return false;
            }


        }
        public Boolean Ramené(Pret pret)
        {
            try
            {
                DataTable data = con.Select("SELECT IdOeuvre FROM Pret WHERE ID='"+pret.id+"' ");
                Objects.Oeuvre oe = new Objects.Oeuvre(Convert.ToInt32(data.Rows[0][0].ToString()), null, null, 0, null, 0);
                con.IUD("DELETE  Pret  WHERE Id='" + pret.id + "' ");
                oe.Incrémenter(oe);
                return true;
            }
            catch (SqlException exp)
            {
                return false;
            }


        }
       


    }
}
