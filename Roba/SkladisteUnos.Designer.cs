namespace Roba
{
    partial class SkladisteUnos
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.spremiButton = new System.Windows.Forms.Button();
            this.adresaTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(161, 85);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 20;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(80, 85);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 19;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // adresaTbox
            // 
            this.adresaTbox.Location = new System.Drawing.Point(80, 48);
            this.adresaTbox.Name = "adresaTbox";
            this.adresaTbox.Size = new System.Drawing.Size(156, 20);
            this.adresaTbox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adresa:";
            // 
            // nazivTbox
            // 
            this.nazivTbox.Location = new System.Drawing.Point(80, 22);
            this.nazivTbox.Name = "nazivTbox";
            this.nazivTbox.Size = new System.Drawing.Size(156, 20);
            this.nazivTbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naziv:";
            // 
            // SkladisteUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 126);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.adresaTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazivTbox);
            this.Controls.Add(this.label1);
            this.Name = "SkladisteUnos";
            this.Text = "SkladisteUnos";
            this.Load += new System.EventHandler(this.SkladisteUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.TextBox adresaTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivTbox;
        private System.Windows.Forms.Label label1;
    }
}