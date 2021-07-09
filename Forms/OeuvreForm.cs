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
    public partial class OeuvreForm : Form
    {
        public static int id;
        public OeuvreForm()
        {
            InitializeComponent();
            AfficherOeuvre();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try { 
            Objects.Oeuvre oe = new Objects.Oeuvre(id,Titretxt.Text, Nomdautxt.Text, Convert.ToInt32(nbrexemptxt.Text), dateréa.Value.ToString(), Convert.ToInt32(CAD.Text));
            
            if (oe.Modifier(oe) == true)
            {
                MessageBox.Show("Oeuvre bien Modifier");
                    AfficherOeuvre();
                    Clear();
                }
            else
            {
                MessageBox.Show("Erreur  De Modification ");
            }
        }
            catch (Exception ex) {
                MessageBox.Show("Erreur de Saisie ");
            }

}
        public void AfficherOeuvre()
        {
            BindingSource bind = new BindingSource();
             Connection  con = new Connection();
            DataTable dt = con.Select("SELECT *  FROM Oeuvre");
            bind.DataSource = dt;
            OeuvreTab.DataSource = bind;
        }

        private void OeuvreTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.OeuvreTab.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            Titretxt.Text = row.Cells[1].Value.ToString();
            Nomdautxt.Text = row.Cells[2].Value.ToString();
            nbrexemptxt.Text = row.Cells[3].Value.ToString();
            dateréa.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
            CAD.Text = row.Cells[5].Value.ToString();
        }

        private void btnValideroe_Click(object sender, EventArgs e)
        {
            try
            {
                Objects.Oeuvre oeu = new Objects.Oeuvre(0, Titretxt.Text, Nomdautxt.Text, Convert.ToInt32(nbrexemptxt.Text), dateréa.Value.ToString(), Convert.ToInt32(CAD.Text));
                if (oeu.Ajouter(oeu) == true)
                {
                    MessageBox.Show("Oeuvre bien Inserer");
                    AfficherOeuvre();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erreur  D'insertion ");
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show("Erreur de Saisie ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Objects.Oeuvre oe = new Objects.Oeuvre(id, null, null, 0, null, 0);

                if (oe.Supprimer(oe) == true)
                {
                    MessageBox.Show("Oeuvre bien Supprimer");
                    AfficherOeuvre();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erreur  De Sppression ");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de Saisie ");
            }
        }
        public void Clear() {

            Titretxt.Clear();
            Nomdautxt.Clear();
            nbrexemptxt.Clear();
            CAD.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Dispose();
        }

        private void Oeuvrepanel_Enter(object sender, EventArgs e)
        {

        }

        private void OeuvreForm_Load(object sender, EventArgs e)
        {
            AfficherOeuvre();
        }
    }
    
}
