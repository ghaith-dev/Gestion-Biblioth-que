using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Bibliothèque.Objects;

namespace Gestion_Bibliothèque.Forms
{
    public partial class SessionForm : Form
    {
        public static int id;
        public SessionForm()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Session session = new Session(0, User.Text, Password.Text);
            try {
                if (session.Ajouter(session)) {
                    MessageBox.Show("la Session est bien Ajouter");
                    AfficherSessions();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erreur à l'ajout de Session");
                }


            } catch (Exception exp) {
                MessageBox.Show("Erreur de Saisie");
                    }
        }
        private void AfficherSessions() {
            Connection cnx = new Connection();
            DataTable data = cnx.Select("SELECT * FROM Login");
            SessionTab.DataSource = data;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfficherSessions();
        }

        private void SessionTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.SessionTab.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            User.Text = row.Cells[1].Value.ToString();
            Password.Text = row.Cells[2].Value.ToString();
        }
        private void Clear()
        {
            User.Clear();
            Password.Clear();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Session session = new Session(id, User.Text, Password.Text);
            try
            {
                if (session.Modifier(session))
                {
                    MessageBox.Show("la Session est bien Modifier");
                    AfficherSessions();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erreur à la Modification de Session");
                }


            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur de Saisie");
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Session session = new Session(id, User.Text, Password.Text);
            try
            {
                if (session.Supprimer(session))
                {
                    MessageBox.Show("la Session est bien Supprimer");
                    AfficherSessions();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erreur à la supprission de Session");
                }


            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur de Saisie");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Dispose();
        }
    }
}
