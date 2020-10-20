namespace Roba
{
    partial class RobaUnos
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
            this.jedcijenaTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opisTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skladisteCbox = new System.Windows.Forms.ComboBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.spremiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // nazivTbox
            // 
            this.nazivTbox.Location = new System.Drawing.Point(79, 12);
            this.nazivTbox.Name = "nazivTbox";
            this.nazivTbox.Size = new System.Drawing.Size(156, 20);
            this.nazivTbox.TabIndex = 1;
            // 
            // jedcijenaTbox
            // 
            this.jedcijenaTbox.Location = new System.Drawing.Point(79, 38);
            this.jedcijenaTbox.Name = "jedcijenaTbox";
            this.jedcijenaTbox.Size = new System.Drawing.Size(156, 20);
            this.jedcijenaTbox.TabIndex = 4;
            this.jedcijenaTbox.Text = "*.**";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jed. cijena:";
            // 
            // opisTbox
            // 
            this.opisTbox.Location = new System.Drawing.Point(79, 89);
            this.opisTbox.Multiline = true;
            this.opisTbox.Name = "opisTbox";
            this.opisTbox.Size = new System.Drawing.Size(156, 75);
            this.opisTbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skladište:";
            // 
            // skladisteCbox
            // 
            this.skladisteCbox.FormattingEnabled = true;
            this.skladisteCbox.Location = new System.Drawing.Point(79, 64);
            this.skladisteCbox.Name = "skladisteCbox";
            this.skladisteCbox.Size = new System.Drawing.Size(121, 21);
            this.skladisteCbox.TabIndex = 8;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(160, 180);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 10;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(79, 180);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 9;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // RobaUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 224);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.skladisteCbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.opisTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jedcijenaTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazivTbox);
            this.Controls.Add(this.label1);
            this.Name = "RobaUnos";
            this.Text = "RobaUnos";
            this.Load += new System.EventHandler(this.RobaUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivTbox;
        private System.Windows.Forms.TextBox jedcijenaTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opisTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox skladisteCbox;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button spremiButton;
    }
}