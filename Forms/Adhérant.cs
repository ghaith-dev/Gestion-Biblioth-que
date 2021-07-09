using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Bibliothèque.Forms;

namespace Gestion_Bibliothèque
{
    
    public partial class Adhérant : Form
    {
        public static int id;
        public Adhérant()
        {
            InitializeComponent();
            Afficher();
        }

        private void AdhérantTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.AdhérantTab.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            Nomtxt.Text = row.Cells[1].Value.ToString();
            prenomtxt.Text = row.Cells[2].Value.ToString();
            Agetxt.Text = row.Cells[3].Value.ToString();
            CINtxt.Text = row.Cells[4].Value.ToString();
            Teltxt.Text = row.Cells[5].Value.ToString();
         
           

            
        }

        private void btnValider_Click(object sender, EventArgs e)

        {
            try
            {
                Objects.Adhérent adh = new Objects.Adhérent(0,Nomtxt.Text, prenomtxt.Text, Convert.ToInt32(Agetxt.Text), Convert.ToInt32(CINtxt.Text), Convert.ToInt32(Teltxt.Text));
                if (adh.Ajouter(adh))
                {
                    MessageBox.Show("Adhérent Bien Ajouter");
                    Afficher();
                    Clear();
                }
                else {
                    MessageBox.Show("Erreur d'Ajout ");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur de Saisie" );

            }
        }
        private void Afficher()
        {
            BindingSource bind = new BindingSource();
            
            Connection con = new Connection();
            DataTable dt = con.Select("SELECT * FROM Adhérent");
            bind.DataSource = dt;
            AdhérantTab.DataSource = bind;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Objects.Adhérent adh = new Objects.Adhérent(id, Nomtxt.Text, prenomtxt.Text, Convert.ToInt32(Agetxt.Text), Convert.ToInt32(CINtxt.Text), Convert.ToInt32(Teltxt.Text));
                if (adh.Modifier(adh))
                {
                    MessageBox.Show("Adhérent Bien Modifier");
                    Afficher();
                    Clear();
                }
                else {
                    MessageBox.Show("Erreur de Modification d'Adhérant");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur de Saisie" );

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Objects.Adhérent adh = new Objects.Adhérent(id, null, null, 0, 0, 0);
                if (adh.Supprimer(adh))
                {
                    MessageBox.Show("Adhérent Bien Supprimer");
                    Afficher();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erreur De Supprission ");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur de Saisie" );

            }
        }
        private void Clear() {
            Nomtxt.Clear();
            prenomtxt.Clear();
            Agetxt.Clear();
            CINtxt.Clear();
            Teltxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Dashboard dash = new Dashboard();
            dash.Show();
        }
    }
    
}
