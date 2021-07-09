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
    public partial class Test21 : Form
    {
        public Test21()
        {
            InitializeComponent();
        }

        private void Ajouterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection con = new Connection();
                float p; 
                float.TryParse(Prixtxt.Text, out p);

                con.IUD("INSERT INTO Article(Marque,Lib,Prix) VALUES('" + Marquetxt.Text + "','" + Libtxt.Text + "','" + p + "')");
            }
            catch (Exception exp) {
                MessageBox.Show("Erreur");
            }
        }
    }
}
