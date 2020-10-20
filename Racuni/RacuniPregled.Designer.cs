namespace Racuni
{
    partial class RacuniPregled
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
            this.racuniDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_izdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupna_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontrola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poslovni_partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaDGV = new System.Windows.Forms.DataGridView();
            this.ID_roba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jedinicna_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodajRacunButton = new System.Windows.Forms.Button();
            this.obrisiRacunButton = new System.Windows.Forms.Button();
            this.dodajStavkuButton = new System.Windows.Forms.Button();
            this.obrisiStavkubutton = new System.Windows.Forms.Button();
            this.partneriCbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izdajRacunButton = new System.Windows.Forms.Button();
            this.otkljucajRacunButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // racuniDGV
            // 
            this.racuniDGV.AllowUserToAddRows = false;
            this.racuniDGV.AllowUserToDeleteRows = false;
            this.racuniDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Datum_izdavanja,
            this.Ukupna_cijena,
            this.Kontrola,
            this.Zaposlenik,
            this.Poslovni_partner});
            this.racuniDGV.Location = new System.Drawing.Point(12, 12);
            this.racuniDGV.Name = "racuniDGV";
            this.racuniDGV.ReadOnly = true;
            this.racuniDGV.Size = new System.Drawing.Size(671, 150);
            this.racuniDGV.TabIndex = 0;
            this.racuniDGV.SelectionChanged += new System.EventHandler(this.racuniDGV_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Datum_izdavanja
            // 
            this.Datum_izdavanja.HeaderText = "Datum izdavanja";
            this.Datum_izdavanja.Name = "Datum_izdavanja";
            this.Datum_izdavanja.ReadOnly = true;
            // 
            // Ukupna_cijena
            // 
            this.Ukupna_cijena.HeaderText = "Ukupna cijena";
            this.Ukupna_cijena.Name = "Ukupna_cijena";
            this.Ukupna_cijena.ReadOnly = true;
            // 
            // Kontrola
            // 
            this.Kontrola.HeaderText = "Izdan?";
            this.Kontrola.Name = "Kontrola";
            this.Kontrola.ReadOnly = true;
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.HeaderText = "Zaposlenik";
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.ReadOnly = true;
            // 
            // Poslovni_partner
            // 
            this.Poslovni_partner.HeaderText = "Poslovni partner";
            this.Poslovni_partner.Name = "Poslovni_partner";
            this.Poslovni_partner.ReadOnly = true;
            // 
            // stavkaDGV
            // 
            this.stavkaDGV.AllowUserToAddRows = false;
            this.stavkaDGV.AllowUserToDeleteRows = false;
            this.stavkaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_roba,
            this.Naziv,
            this.Opis,
            this.Jedinicna_cijena,
            this.Kolicina,
            this.Cijena_stavke});
            this.stavkaDGV.Location = new System.Drawing.Point(12, 245);
            this.stavkaDGV.Name = "stavkaDGV";
            this.stavkaDGV.ReadOnly = true;
            this.stavkaDGV.Size = new System.Drawing.Size(671, 150);
            this.stavkaDGV.TabIndex = 2;
            // 
            // ID_roba
            // 
            this.ID_roba.HeaderText = "ID";
            this.ID_roba.Name = "ID_roba";
            this.ID_roba.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Jedinicna_cijena
            // 
            this.Jedinicna_cijena.HeaderText = "Jedinična cijena";
            this.Jedinicna_cijena.Name = "Jedinicna_cijena";
            this.Jedinicna_cijena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cijena_stavke
            // 
            this.Cijena_stavke.HeaderText = "Cijena stavke";
            this.Cijena_stavke.Name = "Cijena_stavke";
            this.Cijena_stavke.ReadOnly = true;
            // 
            // dodajRacunButton
            // 
            this.dodajRacunButton.Location = new System.Drawing.Point(496, 168);
            this.dodajRacunButton.Name = "dodajRacunButton";
            this.dodajRacunButton.Size = new System.Drawing.Size(89, 23);
            this.dodajRacunButton.TabIndex = 3;
            this.dodajRacunButton.Text = "Dodaj račun";
            this.dodajRacunButton.UseVisualStyleBackColor = true;
            this.dodajRacunButton.Click += new System.EventHandler(this.dodajRacunButton_Click);
            // 
            // obrisiRacunButton
            // 
            this.obrisiRacunButton.Location = new System.Drawing.Point(591, 197);
            this.obrisiRacunButton.Name = "obrisiRacunButton";
            this.obrisiRacunButton.Size = new System.Drawing.Size(92, 23);
            this.obrisiRacunButton.TabIndex = 5;
            this.obrisiRacunButton.Text = "Obriši račun";
            this.obrisiRacunButton.UseVisualStyleBackColor = true;
            this.obrisiRacunButton.Click += new System.EventHandler(this.obrisiRacunButton_Click);
            // 
            // dodajStavkuButton
            // 
            this.dodajStavkuButton.Location = new System.Drawing.Point(496, 401);
            this.dodajStavkuButton.Name = "dodajStavkuButton";
            this.dodajStavkuButton.Size = new System.Drawing.Size(89, 23);
            this.dodajStavkuButton.TabIndex = 6;
            this.dodajStavkuButton.Text = "Dodaj stavku";
            this.dodajStavkuButton.UseVisualStyleBackColor = true;
            this.dodajStavkuButton.Click += new System.EventHandler(this.dodajStavkuButton_Click);
            // 
            // obrisiStavkubutton
            // 
            this.obrisiStavkubutton.Location = new System.Drawing.Point(591, 401);
            this.obrisiStavkubutton.Name = "obrisiStavkubutton";
            this.obrisiStavkubutton.Size = new System.Drawing.Size(92, 23);
            this.obrisiStavkubutton.TabIndex = 7;
            this.obrisiStavkubutton.Text = "Obriši stavku";
            this.obrisiStavkubutton.UseVisualStyleBackColor = true;
            this.obrisiStavkubutton.Click += new System.EventHandler(this.obrisiStavkubutton_Click);
            // 
            // partneriCbox
            // 
            this.partneriCbox.FormattingEnabled = true;
            this.partneriCbox.Location = new System.Drawing.Point(369, 168);
            this.partneriCbox.Name = "partneriCbox";
            this.partneriCbox.Size = new System.Drawing.Size(121, 21);
            this.partneriCbox.TabIndex = 8;
            this.partneriCbox.Click += new System.EventHandler(this.partneriCbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Partner:";
            // 
            // izdajRacunButton
            // 
            this.izdajRacunButton.Location = new System.Drawing.Point(591, 168);
            this.izdajRacunButton.Name = "izdajRacunButton";
            this.izdajRacunButton.Size = new System.Drawing.Size(92, 23);
            this.izdajRacunButton.TabIndex = 10;
            this.izdajRacunButton.Text = "Izdaj račun";
            this.izdajRacunButton.UseVisualStyleBackColor = true;
            this.izdajRacunButton.Click += new System.EventHandler(this.izdajRacunButton_Click);
            // 
            // otkljucajRacunButton
            // 
            this.otkljucajRacunButton.Location = new System.Drawing.Point(493, 197);
            this.otkljucajRacunButton.Name = "otkljucajRacunButton";
            this.otkljucajRacunButton.Size = new System.Drawing.Size(92, 23);
            this.otkljucajRacunButton.TabIndex = 11;
            this.otkljucajRacunButton.Text = "Otključaj račun";
            this.otkljucajRacunButton.UseVisualStyleBackColor = true;
            this.otkljucajRacunButton.Click += new System.EventHandler(this.otkljucajRacunButton_Click);
            // 
            // RacuniPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 441);
            this.Controls.Add(this.otkljucajRacunButton);
            this.Controls.Add(this.izdajRacunButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partneriCbox);
            this.Controls.Add(this.obrisiStavkubutton);
            this.Controls.Add(this.dodajStavkuButton);
            this.Controls.Add(this.obrisiRacunButton);
            this.Controls.Add(this.dodajRacunButton);
            this.Controls.Add(this.stavkaDGV);
            this.Controls.Add(this.racuniDGV);
            this.Name = "RacuniPregled";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.RacuniPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racuniDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView racuniDGV;
        private System.Windows.Forms.DataGridView stavkaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_roba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jedinicna_cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena_stavke;
        private System.Windows.Forms.Button dodajRacunButton;
        private System.Windows.Forms.Button obrisiRacunButton;
        private System.Windows.Forms.Button dodajStavkuButton;
        private System.Windows.Forms.Button obrisiStavkubutton;
        private System.Windows.Forms.ComboBox partneriCbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izdajRacunButton;
        private System.Windows.Forms.Button otkljucajRacunButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_izdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupna_cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontrola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poslovni_partner;
    }
}

