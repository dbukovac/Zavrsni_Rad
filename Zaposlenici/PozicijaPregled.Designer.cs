namespace Zaposlenici
{
    partial class PozicijaPregled
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
            this.pozicijaDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razina_prava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novaPozicijaButton = new System.Windows.Forms.Button();
            this.izmjenipozicijuButton = new System.Windows.Forms.Button();
            this.obrisiPozicijuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pozicijaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pozicijaDGV
            // 
            this.pozicijaDGV.AllowUserToAddRows = false;
            this.pozicijaDGV.AllowUserToDeleteRows = false;
            this.pozicijaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pozicijaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Opis,
            this.Razina_prava});
            this.pozicijaDGV.Location = new System.Drawing.Point(12, 12);
            this.pozicijaDGV.Name = "pozicijaDGV";
            this.pozicijaDGV.ReadOnly = true;
            this.pozicijaDGV.Size = new System.Drawing.Size(562, 150);
            this.pozicijaDGV.TabIndex = 0;
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
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 200;
            // 
            // Razina_prava
            // 
            this.Razina_prava.HeaderText = "Razina prava";
            this.Razina_prava.Name = "Razina_prava";
            this.Razina_prava.ReadOnly = true;
            // 
            // novaPozicijaButton
            // 
            this.novaPozicijaButton.Location = new System.Drawing.Point(282, 168);
            this.novaPozicijaButton.Name = "novaPozicijaButton";
            this.novaPozicijaButton.Size = new System.Drawing.Size(100, 23);
            this.novaPozicijaButton.TabIndex = 1;
            this.novaPozicijaButton.Text = "Nova pozicija";
            this.novaPozicijaButton.UseVisualStyleBackColor = true;
            this.novaPozicijaButton.Click += new System.EventHandler(this.novaPozicijaButton_Click);
            // 
            // izmjenipozicijuButton
            // 
            this.izmjenipozicijuButton.Location = new System.Drawing.Point(388, 168);
            this.izmjenipozicijuButton.Name = "izmjenipozicijuButton";
            this.izmjenipozicijuButton.Size = new System.Drawing.Size(94, 23);
            this.izmjenipozicijuButton.TabIndex = 2;
            this.izmjenipozicijuButton.Text = "Izmjeni poziciju";
            this.izmjenipozicijuButton.UseVisualStyleBackColor = true;
            this.izmjenipozicijuButton.Click += new System.EventHandler(this.izmjenipozicijuButton_Click);
            // 
            // obrisiPozicijuButton
            // 
            this.obrisiPozicijuButton.Location = new System.Drawing.Point(488, 168);
            this.obrisiPozicijuButton.Name = "obrisiPozicijuButton";
            this.obrisiPozicijuButton.Size = new System.Drawing.Size(86, 23);
            this.obrisiPozicijuButton.TabIndex = 3;
            this.obrisiPozicijuButton.Text = "Obriši poziciju";
            this.obrisiPozicijuButton.UseVisualStyleBackColor = true;
            this.obrisiPozicijuButton.Click += new System.EventHandler(this.obrisiPozicijuButton_Click);
            // 
            // PozicijaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 221);
            this.Controls.Add(this.obrisiPozicijuButton);
            this.Controls.Add(this.izmjenipozicijuButton);
            this.Controls.Add(this.novaPozicijaButton);
            this.Controls.Add(this.pozicijaDGV);
            this.Name = "PozicijaPregled";
            this.Text = "PozicijaPregled";
            this.Load += new System.EventHandler(this.PozicijaPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pozicijaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pozicijaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razina_prava;
        private System.Windows.Forms.Button novaPozicijaButton;
        private System.Windows.Forms.Button izmjenipozicijuButton;
        private System.Windows.Forms.Button obrisiPozicijuButton;
    }
}