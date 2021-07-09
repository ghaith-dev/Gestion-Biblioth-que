namespace Gestion_Bibliothèque.Forms
{
    partial class Test21
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
            this.Marquetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Libtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Prixtxt = new System.Windows.Forms.TextBox();
            this.Ajouterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Marquetxt
            // 
            this.Marquetxt.Location = new System.Drawing.Point(158, 49);
            this.Marquetxt.Name = "Marquetxt";
            this.Marquetxt.Size = new System.Drawing.Size(297, 20);
            this.Marquetxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lib";
            // 
            // Libtxt
            // 
            this.Libtxt.Location = new System.Drawing.Point(158, 105);
            this.Libtxt.Name = "Libtxt";
            this.Libtxt.Size = new System.Drawing.Size(297, 20);
            this.Libtxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix";
            // 
            // Prixtxt
            // 
            this.Prixtxt.Location = new System.Drawing.Point(158, 158);
            this.Prixtxt.Name = "Prixtxt";
            this.Prixtxt.Size = new System.Drawing.Size(297, 20);
            this.Prixtxt.TabIndex = 4;
            // 
            // Ajouterbtn
            // 
            this.Ajouterbtn.Location = new System.Drawing.Point(263, 224);
            this.Ajouterbtn.Name = "Ajouterbtn";
            this.Ajouterbtn.Size = new System.Drawing.Size(138, 51);
            this.Ajouterbtn.TabIndex = 6;
            this.Ajouterbtn.Text = "Ajouter";
            this.Ajouterbtn.UseVisualStyleBackColor = true;
            this.Ajouterbtn.Click += new System.EventHandler(this.Ajouterbtn_Click);
            // 
            // Test21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ajouterbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prixtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Libtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Marquetxt);
            this.Name = "Test21";
            this.Text = "Test21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Marquetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Libtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prixtxt;
        private System.Windows.Forms.Button Ajouterbtn;
    }
}