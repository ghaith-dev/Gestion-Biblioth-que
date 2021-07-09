using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Bibliothèque.Objects;

namespace Gestion_Bibliothèque
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
                  }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Nom De l'Utilisateur")
            {
                Username.Text = "";
                Username.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void Password_Enter_1(object sender, EventArgs e)
        {
            if (PasswordL.Text == "Mot De Passe")
            {
                PasswordL.Text = "";
                PasswordL.ForeColor = System.Drawing.Color.Black;
                PasswordL.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Session ses = new Session(0,Username.Text, PasswordL.Text);
                if (ses.Connecter() == true)
                {
                    Forms.Dashboard dash = new Forms.Dashboard();
                    dash.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Nom De utlisateur ou Mot De Passe Invalide");
                }
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur, Saisie Invalide "+exp);
            }
        }
        }
    }

