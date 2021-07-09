namespace Gestion_Bibliothèque
{
    partial class OeuvreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OeuvreTab = new System.Windows.Forms.DataGridView();
            this.Oeuvrepanel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateréa = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnValideroe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nbrexemptxt = new System.Windows.Forms.TextBox();
            this.CAD = new System.Windows.Forms.TextBox();
            this.Nomdautxt = new System.Windows.Forms.TextBox();
            this.Titretxt = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OeuvreTab)).BeginInit();
            this.Oeuvrepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OeuvreTab);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(446, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 649);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // OeuvreTab
            // 
            this.OeuvreTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OeuvreTab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OeuvreTab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OeuvreTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OeuvreTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.OeuvreTab.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OeuvreTab.Location = new System.Drawing.Point(0, 14);
            this.OeuvreTab.Name = "OeuvreTab";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OeuvreTab.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OeuvreTab.Size = new System.Drawing.Size(721, 803);
            this.OeuvreTab.TabIndex = 1;
            this.OeuvreTab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OeuvreTab_CellContentClick);
            // 
            // Oeuvrepanel
            // 
            this.Oeuvrepanel.Controls.Add(this.button1);
            this.Oeuvrepanel.Controls.Add(this.dateréa);
            this.Oeuvrepanel.Controls.Add(this.button9);
            this.Oeuvrepanel.Controls.Add(this.button10);
            this.Oeuvrepanel.Controls.Add(this.btnValideroe);
            this.Oeuvrepanel.Controls.Add(this.label7);
            this.Oeuvrepanel.Controls.Add(this.label8);
            this.Oeuvrepanel.Controls.Add(this.label9);
            this.Oeuvrepanel.Controls.Add(this.label10);
            this.Oeuvrepanel.Controls.Add(this.label11);
            this.Oeuvrepanel.Controls.Add(this.nbrexemptxt);
            this.Oeuvrepanel.Controls.Add(this.CAD);
            this.Oeuvrepanel.Controls.Add(this.Nomdautxt);
            this.Oeuvrepanel.Controls.Add(this.Titretxt);
            this.Oeuvrepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oeuvrepanel.ForeColor = System.Drawing.Color.White;
            this.Oeuvrepanel.Location = new System.Drawing.Point(3, 6);
            this.Oeuvrepanel.Name = "Oeuvrepanel";
            this.Oeuvrepanel.Size = new System.Drawing.Size(437, 672);
            this.Oeuvrepanel.TabIndex = 20;
            this.Oeuvrepanel.TabStop = false;
            this.Oeuvrepanel.Enter += new System.EventHandler(this.Oeuvrepanel_Enter);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateréa
            // 
            this.dateréa.Location = new System.Drawing.Point(156, 329);
            this.dateréa.Name = "dateréa";
            this.dateréa.Size = new System.Drawing.Size(271, 31);
            this.dateréa.TabIndex = 34;
            this.dateréa.Value = new System.DateTime(2020, 6, 26, 0, 0, 0, 0);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(295, 499);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(132, 55);
            this.button9.TabIndex = 32;
            this.button9.Text = "Supprimer\r\n";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(163, 499);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 55);
            this.button10.TabIndex = 31;
            this.button10.Text = "Modifier";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnValideroe
            // 
            this.btnValideroe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValideroe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValideroe.ForeColor = System.Drawing.Color.White;
            this.btnValideroe.Location = new System.Drawing.Point(17, 499);
            this.btnValideroe.Name = "btnValideroe";
            this.btnValideroe.Size = new System.Drawing.Size(133, 55);
            this.btnValideroe.TabIndex = 30;
            this.btnValideroe.Text = "Ajouter";
            this.btnValideroe.UseVisualStyleBackColor = true;
            this.btnValideroe.Click += new System.EventHandler(this.btnValideroe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Code A Barre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 50);
            this.label8.TabIndex = 26;
            this.label8.Text = "Date de Réali\r\nsation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nbr Exemplaire";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nom d\'Auteur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Titre";
            // 
            // nbrexemptxt
            // 
            this.nbrexemptxt.Location = new System.Drawing.Point(156, 247);
            this.nbrexemptxt.Name = "nbrexemptxt";
            this.nbrexemptxt.Size = new System.Drawing.Size(271, 31);
            this.nbrexemptxt.TabIndex = 22;
            // 
            // CAD
            // 
            this.CAD.Location = new System.Drawing.Point(156, 426);
            this.CAD.Name = "CAD";
            this.CAD.Size = new System.Drawing.Size(271, 31);
            this.CAD.TabIndex = 21;
            // 
            // Nomdautxt
            // 
            this.Nomdautxt.Location = new System.Drawing.Point(156, 169);
            this.Nomdautxt.Name = "Nomdautxt";
            this.Nomdautxt.Size = new System.Drawing.Size(271, 31);
            this.Nomdautxt.TabIndex = 19;
            // 
            // Titretxt
            // 
            this.Titretxt.Location = new System.Drawing.Point(156, 87);
            this.Titretxt.Name = "Titretxt";
            this.Titretxt.Size = new System.Drawing.Size(271, 31);
            this.Titretxt.TabIndex = 18;
            this.Titretxt.Text = " ";
            // 
            // OeuvreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1173, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Oeuvrepanel);
            this.Name = "OeuvreForm";
            this.Text = "OeuvreForm";
            this.Load += new System.EventHandler(this.OeuvreForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OeuvreTab)).EndInit();
            this.Oeuvrepanel.ResumeLayout(false);
            this.Oeuvrepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView OeuvreTab;
        private System.Windows.Forms.GroupBox Oeuvrepanel;
        private System.Windows.Forms.DateTimePicker dateréa;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnValideroe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nbrexemptxt;
        private System.Windows.Forms.TextBox CAD;
        private System.Windows.Forms.TextBox Nomdautxt;
        private System.Windows.Forms.TextBox Titretxt;
        private System.Windows.Forms.Button button1;
    }
}