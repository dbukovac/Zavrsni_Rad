namespace Zaposlenici
{
    partial class PozicijaUnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.nazivTbox = new System.Windows.Forms.TextBox();
            this.spremiButton = new System.Windows.Forms.Button();
            this.razinaTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opisTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // nazivTbox
            // 
            this.nazivTbox.Location = new System.Drawing.Point(93, 12);
            this.nazivTbox.Name = "nazivTbox";
            this.nazivTbox.Size = new System.Drawing.Size(135, 20);
            this.nazivTbox.TabIndex = 1;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(93, 159);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 2;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // razinaTbox
            // 
            this.razinaTbox.Location = new System.Drawing.Point(93, 38);
            this.razinaTbox.Name = "razinaTbox";
            this.razinaTbox.Size = new System.Drawing.Size(135, 20);
            this.razinaTbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razina prava:";
            // 
            // opisTbox
            // 
            this.opisTbox.Location = new System.Drawing.Point(93, 64);
            this.opisTbox.Multiline = true;
            this.opisTbox.Name = "opisTbox";
            this.opisTbox.Size = new System.Drawing.Size(135, 67);
            this.opisTbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(197, 159);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // PozicijaUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.opisTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.razinaTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.nazivTbox);
            this.Controls.Add(this.label1);
            this.Name = "PozicijaUnos";
            this.Text = "PozicijaUnos";
            this.Load += new System.EventHandler(this.PozicijaUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivTbox;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.TextBox razinaTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opisTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button odustaniButton;
    }
}