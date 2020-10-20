namespace Racuni
{
    partial class Stavke_racunaUnos
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
            this.robaDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jed_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skladiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajRobuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.robaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // robaDGV
            // 
            this.robaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.robaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Jed_cijena,
            this.Kolicina,
            this.Opis,
            this.Skladiste});
            this.robaDGV.Location = new System.Drawing.Point(3, 12);
            this.robaDGV.Name = "robaDGV";
            this.robaDGV.Size = new System.Drawing.Size(757, 150);
            this.robaDGV.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Jed_cijena
            // 
            this.Jed_cijena.HeaderText = "Jed. cijena";
            this.Jed_cijena.Name = "Jed_cijena";
            this.Jed_cijena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 200;
            // 
            // Skladiste
            // 
            this.Skladiste.HeaderText = "Skladište";
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.ReadOnly = true;
            // 
            // kolicinaTbox
            // 
            this.kolicinaTbox.Location = new System.Drawing.Point(498, 170);
            this.kolicinaTbox.Name = "kolicinaTbox";
            this.kolicinaTbox.Size = new System.Drawing.Size(100, 20);
            this.kolicinaTbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Količina:";
            // 
            // dodajRobuButton
            // 
            this.dodajRobuButton.Location = new System.Drawing.Point(604, 168);
            this.dodajRobuButton.Name = "dodajRobuButton";
            this.dodajRobuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajRobuButton.TabIndex = 4;
            this.dodajRobuButton.Text = "Dodaj robu";
            this.dodajRobuButton.UseVisualStyleBackColor = true;
            this.dodajRobuButton.Click += new System.EventHandler(this.dodajRobuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(685, 168);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 5;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // Stavke_racunaUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 220);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajRobuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kolicinaTbox);
            this.Controls.Add(this.robaDGV);
            this.Name = "Stavke_racunaUnos";
            this.Text = "Stavke racuna";
            this.Load += new System.EventHandler(this.Stavke_racunaUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.robaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView robaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jed_cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skladiste;
        private System.Windows.Forms.TextBox kolicinaTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajRobuButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}