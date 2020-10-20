namespace Roba
{
    partial class RobaPregled
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
            this.obrisiRobuButton = new System.Windows.Forms.Button();
            this.izmjeniRobuButton = new System.Windows.Forms.Button();
            this.novaRobaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.robaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // robaDGV
            // 
            this.robaDGV.AllowUserToAddRows = false;
            this.robaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.robaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Jed_cijena,
            this.Kolicina,
            this.Opis,
            this.Skladiste});
            this.robaDGV.Location = new System.Drawing.Point(12, 12);
            this.robaDGV.Name = "robaDGV";
            this.robaDGV.ReadOnly = true;
            this.robaDGV.Size = new System.Drawing.Size(752, 150);
            this.robaDGV.TabIndex = 0;
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
            // obrisiRobuButton
            // 
            this.obrisiRobuButton.Location = new System.Drawing.Point(676, 168);
            this.obrisiRobuButton.Name = "obrisiRobuButton";
            this.obrisiRobuButton.Size = new System.Drawing.Size(88, 23);
            this.obrisiRobuButton.TabIndex = 6;
            this.obrisiRobuButton.Text = "Obriši robu";
            this.obrisiRobuButton.UseVisualStyleBackColor = true;
            this.obrisiRobuButton.Click += new System.EventHandler(this.obrisiRobuButton_Click);
            // 
            // izmjeniRobuButton
            // 
            this.izmjeniRobuButton.Location = new System.Drawing.Point(577, 168);
            this.izmjeniRobuButton.Name = "izmjeniRobuButton";
            this.izmjeniRobuButton.Size = new System.Drawing.Size(93, 23);
            this.izmjeniRobuButton.TabIndex = 5;
            this.izmjeniRobuButton.Text = "Izmjeni robu";
            this.izmjeniRobuButton.UseVisualStyleBackColor = true;
            this.izmjeniRobuButton.Click += new System.EventHandler(this.izmjeniRobuButton_Click);
            // 
            // novaRobaButton
            // 
            this.novaRobaButton.Location = new System.Drawing.Point(496, 168);
            this.novaRobaButton.Name = "novaRobaButton";
            this.novaRobaButton.Size = new System.Drawing.Size(75, 23);
            this.novaRobaButton.TabIndex = 4;
            this.novaRobaButton.Text = "Nova roba";
            this.novaRobaButton.UseVisualStyleBackColor = true;
            this.novaRobaButton.Click += new System.EventHandler(this.novaRobaButton_Click);
            // 
            // RobaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 214);
            this.Controls.Add(this.obrisiRobuButton);
            this.Controls.Add(this.izmjeniRobuButton);
            this.Controls.Add(this.novaRobaButton);
            this.Controls.Add(this.robaDGV);
            this.Name = "RobaPregled";
            this.Text = "Roba";
            this.Load += new System.EventHandler(this.RobaPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.robaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView robaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jed_cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skladiste;
        private System.Windows.Forms.Button obrisiRobuButton;
        private System.Windows.Forms.Button izmjeniRobuButton;
        private System.Windows.Forms.Button novaRobaButton;
    }
}

