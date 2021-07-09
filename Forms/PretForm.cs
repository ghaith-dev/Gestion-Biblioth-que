using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Bibliothèque.Forms
{
    
    public partial class PretForm : Form
    {
        private static int id;
        public PretForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PretForm_Load(object sender, EventArgs e)
        {
            Connection cnx = new Connection();
            DataTable data = cnx.Select("Select * From Adhérent");
            DataTable data2=cnx.Select("Select * From Oeuvre ");
            // TODO: This line of code loads data into the 'databaseDataSet.Oeuvre' table. You can move, or remove it, as needed.
            this.oeuvreTableAdapter.Fill(this.databaseDataSet.Oeuvre);
            // TODO: This line of code loads data into the 'databaseDataSet.Adhérent' table. You can move, or remove it, as needed.
            this.adhérentTableAdapter.Fill(this.databaseDataSet.Adhérent);
            //this.databaseDataSet.Adhérent.DataSet.CreateDataReader(data);
           // this.databaseDataSet.Oeuvre.DataSet.CreateDataReader(data2);
            AfficherPret();

        }

        private void validerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                Objects.Adhérent ad = new Objects.Adhérent(Convert.ToInt32(Adhérent.SelectedValue.ToString()), null, null, 0, 0, 0);
                Objects.Oeuvre oe = new Objects.Oeuvre(Convert.ToInt32(Oeuvre.SelectedValue.ToString()), null, null, 0, null, 0);
                Objects.Pret pr = new Objects.Pret(0, ad, oe);
                if (oe.isDisponible(oe) == false)
                {
                    MessageBox.Show("Oeuvre Indisponible");
                }
                else
                {
                    if (pr.EffectuerPret(pr))
                    {
                        oe.Decrémenter(oe);
                        MessageBox.Show("Operation Effectuer Ave Sucsses");
                        AfficherPret();

                    }
                    else
                    {
                        MessageBox.Show("Erreur");
                    }
                }
            }
            catch (Exception exp) {
                MessageBox.Show("Erreur de Saisie" +exp.ToString()) ;

            }
        }
        public void AfficherPret() {
            Connection cnx = new Connection();
            DataTable data = cnx.Select(" SELECT Pret.Id, Nom,Prénom,CIN,Titre,Auteur,CDAB  FROM Adhérent,Oeuvre,Pret WHERE Pret.IdAdhé=Adhérent.Id AND Pret.IdOeuvre=Oeuvre.Id  ");
            PretTab.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Dispose();
        }

        private void Ramenébtn_Click(object sender, EventArgs e)
        {
            try
            {

                Objects.Adhérent ad = new Objects.Adhérent(0, null, null, 0, 0, 0);
                Objects.Oeuvre oe = new Objects.Oeuvre(0, null, null, 0, null, 0);
                Objects.Pret pr = new Objects.Pret(id, ad, oe);
               
                
                
                    if (pr.Ramené(pr))
                    {
                        
                        MessageBox.Show("Operation Effectuer Ave Sucsses");
                        AfficherPret();

                    }
                    else
                    {
                        MessageBox.Show("Erreur");
                    }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur de Saisie" + exp.ToString());

            }
        }

        private void PretTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.PretTab.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value.ToString());
        }
    }
}
