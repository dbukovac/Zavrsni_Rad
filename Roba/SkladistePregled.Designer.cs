namespace Roba
{
    partial class SkladistePregled
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
            this.skladisteDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrisiSkladisteButton = new System.Windows.Forms.Button();
            this.izmjeniSkladisteButton = new System.Windows.Forms.Button();
            this.novoSkladisteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // skladisteDGV
            // 
            this.skladisteDGV.AllowUserToAddRows = false;
            this.skladisteDGV.AllowUserToDeleteRows = false;
            this.skladisteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skladisteDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Adresa});
            this.skladisteDGV.Location = new System.Drawing.Point(12, 12);
            this.skladisteDGV.Name = "skladisteDGV";
            this.skladisteDGV.ReadOnly = true;
            this.skladisteDGV.Size = new System.Drawing.Size(356, 150);
            this.skladisteDGV.TabIndex = 0;
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
            // Adresa
            // 
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // obrisiSkladisteButton
            // 
            this.obrisiSkladisteButton.Location = new System.Drawing.Point(280, 168);
            this.obrisiSkladisteButton.Name = "obrisiSkladisteButton";
            this.obrisiSkladisteButton.Size = new System.Drawing.Size(88, 23);
            this.obrisiSkladisteButton.TabIndex = 9;
            this.obrisiSkladisteButton.Text = "Obriši skladište";
            this.obrisiSkladisteButton.UseVisualStyleBackColor = true;
            this.obrisiSkladisteButton.Click += new System.EventHandler(this.obrisiSkladisteButton_Click);
            // 
            // izmjeniSkladisteButton
            // 
            this.izmjeniSkladisteButton.Location = new System.Drawing.Point(181, 168);
            this.izmjeniSkladisteButton.Name = "izmjeniSkladisteButton";
            this.izmjeniSkladisteButton.Size = new System.Drawing.Size(93, 23);
            this.izmjeniSkladisteButton.TabIndex = 8;
            this.izmjeniSkladisteButton.Text = "Izmjeni skladište";
            this.izmjeniSkladisteButton.UseVisualStyleBackColor = true;
            this.izmjeniSkladisteButton.Click += new System.EventHandler(this.izmjeniSkladisteButton_Click);
            // 
            // novoSkladisteButton
            // 
            this.novoSkladisteButton.Location = new System.Drawing.Point(87, 168);
            this.novoSkladisteButton.Name = "novoSkladisteButton";
            this.novoSkladisteButton.Size = new System.Drawing.Size(88, 23);
            this.novoSkladisteButton.TabIndex = 7;
            this.novoSkladisteButton.Text = "Novo skladište";
            this.novoSkladisteButton.UseVisualStyleBackColor = true;
            this.novoSkladisteButton.Click += new System.EventHandler(this.novoSkladisteButton_Click);
            // 
            // SkladistePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 222);
            this.Controls.Add(this.obrisiSkladisteButton);
            this.Controls.Add(this.izmjeniSkladisteButton);
            this.Controls.Add(this.novoSkladisteButton);
            this.Controls.Add(this.skladisteDGV);
            this.Name = "SkladistePregled";
            this.Text = "SkladistePregled";
            this.Load += new System.EventHandler(this.SkladistePregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView skladisteDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.Button obrisiSkladisteButton;
        private System.Windows.Forms.Button izmjeniSkladisteButton;
        private System.Windows.Forms.Button novoSkladisteButton;
    }
}