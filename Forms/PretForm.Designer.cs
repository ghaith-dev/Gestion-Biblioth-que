namespace Gestion_Bibliothèque.Forms
{
    partial class PretForm
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
            this.components = new System.ComponentModel.Container();
            this.Adhérent = new System.Windows.Forms.ComboBox();
            this.adhérentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Gestion_Bibliothèque.DatabaseDataSet();
            this.Oeuvre = new System.Windows.Forms.ComboBox();
            this.oeuvreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oeuvreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Adhérentlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validerbtn = new System.Windows.Forms.Button();
            this.adhérentTableAdapter = new Gestion_Bibliothèque.DatabaseDataSetTableAdapters.AdhérentTableAdapter();
            this.oeuvreTableAdapter = new Gestion_Bibliothèque.DatabaseDataSetTableAdapters.OeuvreTableAdapter();
            this.oeuvreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PretTab = new System.Windows.Forms.DataGridView();
            this.Ramenébtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adhérentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvreBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretTab)).BeginInit();
            this.SuspendLayout();
            // 
            // Adhérent
            // 
            this.Adhérent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.databaseDataSet, "Adhérent.Id", true));
            this.Adhérent.DataSource = this.databaseDataSet;
            this.Adhérent.DisplayMember = "Adhérent.Nom";
            this.Adhérent.FormattingEnabled = true;
            this.Adhérent.Location = new System.Drawing.Point(149, 29);
            this.Adhérent.Name = "Adhérent";
            this.Adhérent.Size = new System.Drawing.Size(159, 21);
            this.Adhérent.TabIndex = 0;
            this.Adhérent.ValueMember = "Adhérent.Id";
            this.Adhérent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // adhérentBindingSource
            // 
            this.adhérentBindingSource.DataMember = "Adhérent";
            this.adhérentBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Oeuvre
            // 
            this.Oeuvre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.databaseDataSet, "Oeuvre.Id", true));
            this.Oeuvre.DataSource = this.databaseDataSet;
            this.Oeuvre.DisplayMember = "Oeuvre.Titre";
            this.Oeuvre.FormattingEnabled = true;
            this.Oeuvre.Location = new System.Drawing.Point(407, 29);
            this.Oeuvre.Name = "Oeuvre";
            this.Oeuvre.Size = new System.Drawing.Size(159, 21);
            this.Oeuvre.TabIndex = 1;
            this.Oeuvre.ValueMember = "Oeuvre.Id";
            // 
            // oeuvreBindingSource
            // 
            this.oeuvreBindingSource.DataMember = "Oeuvre";
            this.oeuvreBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // oeuvreBindingSource2
            // 
            this.oeuvreBindingSource2.DataMember = "Oeuvre";
            this.oeuvreBindingSource2.DataSource = this.databaseDataSetBindingSource;
            // 
            // Adhérentlbl
            // 
            this.Adhérentlbl.AutoSize = true;
            this.Adhérentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adhérentlbl.ForeColor = System.Drawing.Color.White;
            this.Adhérentlbl.Location = new System.Drawing.Point(54, 32);
            this.Adhérentlbl.Name = "Adhérentlbl";
            this.Adhérentlbl.Size = new System.Drawing.Size(70, 16);
            this.Adhérentlbl.TabIndex = 2;
            this.Adhérentlbl.Text = "Adhérent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oeuvre";
            // 
            // validerbtn
            // 
            this.validerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerbtn.ForeColor = System.Drawing.Color.White;
            this.validerbtn.Location = new System.Drawing.Point(609, 26);
            this.validerbtn.Name = "validerbtn";
            this.validerbtn.Size = new System.Drawing.Size(130, 28);
            this.validerbtn.TabIndex = 4;
            this.validerbtn.Text = "Valider";
            this.validerbtn.UseVisualStyleBackColor = true;
            this.validerbtn.Click += new System.EventHandler(this.validerbtn_Click);
            // 
            // adhérentTableAdapter
            // 
            this.adhérentTableAdapter.ClearBeforeFill = true;
            // 
            // oeuvreTableAdapter
            // 
            this.oeuvreTableAdapter.ClearBeforeFill = true;
            // 
            // oeuvreBindingSource1
            // 
            this.oeuvreBindingSource1.DataMember = "Oeuvre";
            this.oeuvreBindingSource1.DataSource = this.databaseDataSetBindingSource;
            // 
            // PretTab
            // 
            this.PretTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PretTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PretTab.Location = new System.Drawing.Point(-1, 110);
            this.PretTab.Name = "PretTab";
            this.PretTab.Size = new System.Drawing.Size(885, 340);
            this.PretTab.TabIndex = 5;
            this.PretTab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PretTab_CellContentClick);
            // 
            // Ramenébtn
            // 
            this.Ramenébtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ramenébtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ramenébtn.ForeColor = System.Drawing.Color.White;
            this.Ramenébtn.Location = new System.Drawing.Point(609, 76);
            this.Ramenébtn.Name = "Ramenébtn";
            this.Ramenébtn.Size = new System.Drawing.Size(130, 28);
            this.Ramenébtn.TabIndex = 6;
            this.Ramenébtn.Text = "Ramené";
            this.Ramenébtn.UseVisualStyleBackColor = true;
            this.Ramenébtn.Click += new System.EventHandler(this.Ramenébtn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(774, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PretForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ramenébtn);
            this.Controls.Add(this.PretTab);
            this.Controls.Add(this.validerbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adhérentlbl);
            this.Controls.Add(this.Oeuvre);
            this.Controls.Add(this.Adhérent);
            this.Name = "PretForm";
            this.Text = "PretForm";
            this.Load += new System.EventHandler(this.PretForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adhérentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvreBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeuvreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Adhérent;
        private System.Windows.Forms.ComboBox Oeuvre;
        private System.Windows.Forms.Label Adhérentlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validerbtn;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource adhérentBindingSource;
        private DatabaseDataSetTableAdapters.AdhérentTableAdapter adhérentTableAdapter;
        private System.Windows.Forms.BindingSource oeuvreBindingSource;
        private DatabaseDataSetTableAdapters.OeuvreTableAdapter oeuvreTableAdapter;
        private System.Windows.Forms.BindingSource oeuvreBindingSource1;
        private System.Windows.Forms.BindingSource oeuvreBindingSource2;
        private System.Windows.Forms.DataGridView PretTab;
        private System.Windows.Forms.Button Ramenébtn;
        private System.Windows.Forms.Button button1;
    }
}