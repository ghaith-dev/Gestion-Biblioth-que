using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Gestion_Bibliothèque.Objects;

namespace Gestion_Bibliothèque.Forms
{
    public partial class Dashboard : Form
    {
        public static int id;
        public Dashboard()
        {
            InitializeComponent();
           


            


           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Dureécmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Adhérant adh = new Adhérant();
            adh.Show();
            this.Dispose();
            
        }

        private void AdhérantTab_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                   }

        private void btnValideroe_Click(object sender, EventArgs e)
        {
                  
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            OeuvreForm ofrom = new OeuvreForm();
            ofrom.Show();
            this.Dispose();
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            
        }

        private void AdhérantTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void adh1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PretForm form = new PretForm();
            form.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage();
            log.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SessionForm s = new SessionForm();
            s.Show();
            this.Dispose();
        }
    }
   
}
