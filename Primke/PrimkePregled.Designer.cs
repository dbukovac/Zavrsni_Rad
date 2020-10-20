namespace Primke
{
    partial class PrimkePregled
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
            this.otkljucajPrimkuButton = new System.Windows.Forms.Button();
            this.izdajPrimkuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.partneriCbox = new System.Windows.Forms.ComboBox();
            this.obrisiStavkubutton = new System.Windows.Forms.Button();
            this.dodajStavkuButton = new System.Windows.Forms.Button();
            this.obrisiPrimkuButton = new System.Windows.Forms.Button();
            this.dodajPrimkuButton = new System.Windows.Forms.Button();
            this.stavkaDGV = new System.Windows.Forms.DataGridView();
            this.ID_roba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkaDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_izdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontrola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poslovni_partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // otkljucajPrimkuButton
            // 
            this.otkljucajPrimkuButton.Location = new System.Drawing.Point(402, 202);
            this.otkljucajPrimkuButton.Name = "otkljucajPrimkuButton";
            this.otkljucajPrimkuButton.Size = new System.Drawing.Size(92, 23);
            this.otkljucajPrimkuButton.TabIndex = 21;
            this.otkljucajPrimkuButton.Text = "Otključaj primku";
            this.otkljucajPrimkuButton.UseVisualStyleBackColor = true;
            this.otkljucajPrimkuButton.Click += new System.EventHandler(this.otkljucajPrimkuButton_Click);
            // 
            // izdajPrimkuButton
            // 
            this.izdajPrimkuButton.Location = new System.Drawing.Point(500, 173);
            this.izdajPrimkuButton.Name = "izdajPrimkuButton";
            this.izdajPrimkuButton.Size = new System.Drawing.Size(92, 23);
            this.izdajPrimkuButton.TabIndex = 20;
            this.izdajPrimkuButton.Text = "Zaključaj primku";
            this.izdajPrimkuButton.UseVisualStyleBackColor = true;
            this.izdajPrimkuButton.Click += new System.EventHandler(this.izdajPrimkuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Partner:";
            // 
            // partneriCbox
            // 
            this.partneriCbox.FormattingEnabled = true;
            this.partneriCbox.Location = new System.Drawing.Point(278, 173);
            this.partneriCbox.Name = "partneriCbox";
            this.partneriCbox.Size = new System.Drawing.Size(121, 21);
            this.partneriCbox.TabIndex = 18;
            this.partneriCbox.Click += new System.EventHandler(this.partneriCbox_Click);
            // 
            // obrisiStavkubutton
            // 
            this.obrisiStavkubutton.Location = new System.Drawing.Point(500, 406);
            this.obrisiStavkubutton.Name = "obrisiStavkubutton";
            this.obrisiStavkubutton.Size = new System.Drawing.Size(92, 23);
            this.obrisiStavkubutton.TabIndex = 17;
            this.obrisiStavkubutton.Text = "Obriši stavku";
            this.obrisiStavkubutton.UseVisualStyleBackColor = true;
            this.obrisiStavkubutton.Click += new System.EventHandler(this.obrisiStavkubutton_Click);
            // 
            // dodajStavkuButton
            // 
            this.dodajStavkuButton.Location = new System.Drawing.Point(405, 406);
            this.dodajStavkuButton.Name = "dodajStavkuButton";
            this.dodajStavkuButton.Size = new System.Drawing.Size(89, 23);
            this.dodajStavkuButton.TabIndex = 16;
            this.dodajStavkuButton.Text = "Dodaj stavku";
            this.dodajStavkuButton.UseVisualStyleBackColor = true;
            this.dodajStavkuButton.Click += new System.EventHandler(this.dodajStavkuButton_Click);
            // 
            // obrisiPrimkuButton
            // 
            this.obrisiPrimkuButton.Location = new System.Drawing.Point(500, 202);
            this.obrisiPrimkuButton.Name = "obrisiPrimkuButton";
            this.obrisiPrimkuButton.Size = new System.Drawing.Size(92, 23);
            this.obrisiPrimkuButton.TabIndex = 15;
            this.obrisiPrimkuButton.Text = "Obriši primku";
            this.obrisiPrimkuButton.UseVisualStyleBackColor = true;
            this.obrisiPrimkuButton.Click += new System.EventHandler(this.obrisiPrimkuButton_Click);
            // 
            // dodajPrimkuButton
            // 
            this.dodajPrimkuButton.Location = new System.Drawing.Point(405, 173);
            this.dodajPrimkuButton.Name = "dodajPrimkuButton";
            this.dodajPrimkuButton.Size = new System.Drawing.Size(89, 23);
            this.dodajPrimkuButton.TabIndex = 14;
            this.dodajPrimkuButton.Text = "Dodaj primku";
            this.dodajPrimkuButton.UseVisualStyleBackColor = true;
            this.dodajPrimkuButton.Click += new System.EventHandler(this.dodajPrimkuButton_Click);
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
            this.Kolicina});
            this.stavkaDGV.Location = new System.Drawing.Point(19, 250);
            this.stavkaDGV.Name = "stavkaDGV";
            this.stavkaDGV.ReadOnly = true;
            this.stavkaDGV.Size = new System.Drawing.Size(573, 150);
            this.stavkaDGV.TabIndex = 13;
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
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // primkaDGV
            // 
            this.primkaDGV.AllowUserToAddRows = false;
            this.primkaDGV.AllowUserToDeleteRows = false;
            this.primkaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primkaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Datum_izdavanja,
            this.Kontrola,
            this.Zaposlenik,
            this.Poslovni_partner});
            this.primkaDGV.Location = new System.Drawing.Point(19, 17);
            this.primkaDGV.Name = "primkaDGV";
            this.primkaDGV.ReadOnly = true;
            this.primkaDGV.Size = new System.Drawing.Size(573, 150);
            this.primkaDGV.TabIndex = 12;
            this.primkaDGV.SelectionChanged += new System.EventHandler(this.primkaDGV_SelectionChanged_1);
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
            // PrimkePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 446);
            this.Controls.Add(this.otkljucajPrimkuButton);
            this.Controls.Add(this.izdajPrimkuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partneriCbox);
            this.Controls.Add(this.obrisiStavkubutton);
            this.Controls.Add(this.dodajStavkuButton);
            this.Controls.Add(this.obrisiPrimkuButton);
            this.Controls.Add(this.dodajPrimkuButton);
            this.Controls.Add(this.stavkaDGV);
            this.Controls.Add(this.primkaDGV);
            this.Name = "PrimkePregled";
            this.Text = "Primke";
            this.Load += new System.EventHandler(this.PrimkePregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button otkljucajPrimkuButton;
        private System.Windows.Forms.Button izdajPrimkuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox partneriCbox;
        private System.Windows.Forms.Button obrisiStavkubutton;
        private System.Windows.Forms.Button dodajStavkuButton;
        private System.Windows.Forms.Button obrisiPrimkuButton;
        private System.Windows.Forms.Button dodajPrimkuButton;
        private System.Windows.Forms.DataGridView stavkaDGV;
        private System.Windows.Forms.DataGridView primkaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_roba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_izdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontrola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poslovni_partner;
    }
}

