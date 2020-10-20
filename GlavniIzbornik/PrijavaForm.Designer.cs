namespace GlavniIzbornik
{
    partial class PrijavaForm
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
            this.korimeTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LozinkaTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // korimeTbox
            // 
            this.korimeTbox.Location = new System.Drawing.Point(63, 56);
            this.korimeTbox.Name = "korimeTbox";
            this.korimeTbox.Size = new System.Drawing.Size(127, 20);
            this.korimeTbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime";
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(92, 170);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 23);
            this.prijavaButton.TabIndex = 2;
            this.prijavaButton.Text = "Prijavi se";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka";
            // 
            // LozinkaTbox
            // 
            this.LozinkaTbox.Location = new System.Drawing.Point(63, 124);
            this.LozinkaTbox.Name = "LozinkaTbox";
            this.LozinkaTbox.PasswordChar = '*';
            this.LozinkaTbox.Size = new System.Drawing.Size(127, 20);
            this.LozinkaTbox.TabIndex = 3;
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LozinkaTbox);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.korimeTbox);
            this.Name = "PrijavaForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox korimeTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LozinkaTbox;
    }
}