namespace Zaposlenici
{
    partial class ZaposleniciPregled
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
            this.zaposleniciDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonski_broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj_racuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisničko_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noviZaposlenikButton = new System.Windows.Forms.Button();
            this.obrisiZposlenikButton = new System.Windows.Forms.Button();
            this.izmjeniZaposlenikaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposleniciDGV
            // 
            this.zaposleniciDGV.AllowUserToAddRows = false;
            this.zaposleniciDGV.AllowUserToDeleteRows = false;
            this.zaposleniciDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposleniciDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.Telefonski_broj,
            this.Adresa,
            this.OIB,
            this.Broj_racuna,
            this.Korisničko_ime,
            this.Lozinka,
            this.Pozicija});
            this.zaposleniciDGV.Location = new System.Drawing.Point(12, 12);
            this.zaposleniciDGV.Name = "zaposleniciDGV";
            this.zaposleniciDGV.ReadOnly = true;
            this.zaposleniciDGV.Size = new System.Drawing.Size(889, 150);
            this.zaposleniciDGV.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 80;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 80;
            // 
            // Telefonski_broj
            // 
            this.Telefonski_broj.HeaderText = "Telefonski broj";
            this.Telefonski_broj.Name = "Telefonski_broj";
            this.Telefonski_broj.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // OIB
            // 
            this.OIB.HeaderText = "OIB";
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            // 
            // Broj_racuna
            // 
            this.Broj_racuna.HeaderText = "Broj računa";
            this.Broj_racuna.Name = "Broj_racuna";
            this.Broj_racuna.ReadOnly = true;
            // 
            // Korisničko_ime
            // 
            this.Korisničko_ime.HeaderText = "Korisničko ime";
            this.Korisničko_ime.Name = "Korisničko_ime";
            this.Korisničko_ime.ReadOnly = true;
            this.Korisničko_ime.Width = 80;
            // 
            // Lozinka
            // 
            this.Lozinka.HeaderText = "Lozinka";
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.ReadOnly = true;
            this.Lozinka.Width = 80;
            // 
            // Pozicija
            // 
            this.Pozicija.HeaderText = "Pozicija";
            this.Pozicija.Name = "Pozicija";
            this.Pozicija.ReadOnly = true;
            this.Pozicija.Width = 80;
            // 
            // noviZaposlenikButton
            // 
            this.noviZaposlenikButton.Location = new System.Drawing.Point(574, 168);
            this.noviZaposlenikButton.Name = "noviZaposlenikButton";
            this.noviZaposlenikButton.Size = new System.Drawing.Size(99, 23);
            this.noviZaposlenikButton.TabIndex = 1;
            this.noviZaposlenikButton.Text = "Novi zaposlenik";
            this.noviZaposlenikButton.UseVisualStyleBackColor = true;
            this.noviZaposlenikButton.Click += new System.EventHandler(this.noviZaposlenikButton_Click);
            // 
            // obrisiZposlenikButton
            // 
            this.obrisiZposlenikButton.Location = new System.Drawing.Point(796, 168);
            this.obrisiZposlenikButton.Name = "obrisiZposlenikButton";
            this.obrisiZposlenikButton.Size = new System.Drawing.Size(108, 23);
            this.obrisiZposlenikButton.TabIndex = 2;
            this.obrisiZposlenikButton.Text = "Obrisi zaposlenika";
            this.obrisiZposlenikButton.UseVisualStyleBackColor = true;
            this.obrisiZposlenikButton.Click += new System.EventHandler(this.obrisiZposlenikButton_Click);
            // 
            // izmjeniZaposlenikaButton
            // 
            this.izmjeniZaposlenikaButton.Location = new System.Drawing.Point(679, 168);
            this.izmjeniZaposlenikaButton.Name = "izmjeniZaposlenikaButton";
            this.izmjeniZaposlenikaButton.Size = new System.Drawing.Size(111, 23);
            this.izmjeniZaposlenikaButton.TabIndex = 2;
            this.izmjeniZaposlenikaButton.Text = "Izmjeni zaposlenika";
            this.izmjeniZaposlenikaButton.UseVisualStyleBackColor = true;
            this.izmjeniZaposlenikaButton.Click += new System.EventHandler(this.izmjeniZaposlenikaButton_Click);
            // 
            // ZaposleniciPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 232);
            this.Controls.Add(this.izmjeniZaposlenikaButton);
            this.Controls.Add(this.obrisiZposlenikButton);
            this.Controls.Add(this.noviZaposlenikButton);
            this.Controls.Add(this.zaposleniciDGV);
            this.Name = "ZaposleniciPregled";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.ZaposleniciPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zaposleniciDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonski_broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj_racuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisničko_ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lozinka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
        private System.Windows.Forms.Button noviZaposlenikButton;
        private System.Windows.Forms.Button obrisiZposlenikButton;
        private System.Windows.Forms.Button izmjeniZaposlenikaButton;
    }
}

