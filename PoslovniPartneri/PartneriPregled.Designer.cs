namespace PoslovniPartneri
{
    partial class PartneriPregled
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
            this.partneriDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonski_broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj_racuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip_partnera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noviPartnerButton = new System.Windows.Forms.Button();
            this.izmjeniPartneraButton = new System.Windows.Forms.Button();
            this.obrisiPartneraButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partneriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // partneriDGV
            // 
            this.partneriDGV.AllowUserToAddRows = false;
            this.partneriDGV.AllowUserToDeleteRows = false;
            this.partneriDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partneriDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.OIB,
            this.Telefonski_broj,
            this.Adresa,
            this.Broj_racuna,
            this.Tip_partnera});
            this.partneriDGV.Location = new System.Drawing.Point(12, 12);
            this.partneriDGV.Name = "partneriDGV";
            this.partneriDGV.ReadOnly = true;
            this.partneriDGV.Size = new System.Drawing.Size(746, 168);
            this.partneriDGV.TabIndex = 0;
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
            // OIB
            // 
            this.OIB.HeaderText = "OIB";
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
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
            // Broj_racuna
            // 
            this.Broj_racuna.HeaderText = "Broj računa";
            this.Broj_racuna.Name = "Broj_racuna";
            this.Broj_racuna.ReadOnly = true;
            // 
            // Tip_partnera
            // 
            this.Tip_partnera.HeaderText = "Tip partnera";
            this.Tip_partnera.Name = "Tip_partnera";
            this.Tip_partnera.ReadOnly = true;
            // 
            // noviPartnerButton
            // 
            this.noviPartnerButton.Location = new System.Drawing.Point(490, 186);
            this.noviPartnerButton.Name = "noviPartnerButton";
            this.noviPartnerButton.Size = new System.Drawing.Size(75, 23);
            this.noviPartnerButton.TabIndex = 1;
            this.noviPartnerButton.Text = "Novi partner";
            this.noviPartnerButton.UseVisualStyleBackColor = true;
            this.noviPartnerButton.Click += new System.EventHandler(this.noviPartnerButton_Click);
            // 
            // izmjeniPartneraButton
            // 
            this.izmjeniPartneraButton.Location = new System.Drawing.Point(571, 186);
            this.izmjeniPartneraButton.Name = "izmjeniPartneraButton";
            this.izmjeniPartneraButton.Size = new System.Drawing.Size(93, 23);
            this.izmjeniPartneraButton.TabIndex = 2;
            this.izmjeniPartneraButton.Text = "Izmjeni partnera";
            this.izmjeniPartneraButton.UseVisualStyleBackColor = true;
            this.izmjeniPartneraButton.Click += new System.EventHandler(this.izmjeniPartneraButton_Click);
            // 
            // obrisiPartneraButton
            // 
            this.obrisiPartneraButton.Location = new System.Drawing.Point(670, 186);
            this.obrisiPartneraButton.Name = "obrisiPartneraButton";
            this.obrisiPartneraButton.Size = new System.Drawing.Size(88, 23);
            this.obrisiPartneraButton.TabIndex = 3;
            this.obrisiPartneraButton.Text = "Obriši partnera";
            this.obrisiPartneraButton.UseVisualStyleBackColor = true;
            this.obrisiPartneraButton.Click += new System.EventHandler(this.obrisiPartneraButton_Click);
            // 
            // PartneriPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 240);
            this.Controls.Add(this.obrisiPartneraButton);
            this.Controls.Add(this.izmjeniPartneraButton);
            this.Controls.Add(this.noviPartnerButton);
            this.Controls.Add(this.partneriDGV);
            this.Name = "PartneriPregled";
            this.Text = "Poslovni partneri";
            this.Load += new System.EventHandler(this.PartneriPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partneriDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView partneriDGV;
        private System.Windows.Forms.Button noviPartnerButton;
        private System.Windows.Forms.Button izmjeniPartneraButton;
        private System.Windows.Forms.Button obrisiPartneraButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonski_broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj_racuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip_partnera;
    }
}

