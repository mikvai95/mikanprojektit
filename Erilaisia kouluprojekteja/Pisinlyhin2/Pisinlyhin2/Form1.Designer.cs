namespace Pisinlyhin2
{
    partial class Form1
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
            this.Pisinetunimi = new System.Windows.Forms.Button();
            this.Lyhinetunimi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vastaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pisinetunimi
            // 
            this.Pisinetunimi.Location = new System.Drawing.Point(89, 67);
            this.Pisinetunimi.Name = "Pisinetunimi";
            this.Pisinetunimi.Size = new System.Drawing.Size(121, 23);
            this.Pisinetunimi.TabIndex = 0;
            this.Pisinetunimi.Text = "Etsi pisin etunimi";
            this.Pisinetunimi.UseVisualStyleBackColor = true;
            this.Pisinetunimi.Click += new System.EventHandler(this.Pisinetunimi_Click);
            // 
            // Lyhinetunimi
            // 
            this.Lyhinetunimi.Location = new System.Drawing.Point(89, 96);
            this.Lyhinetunimi.Name = "Lyhinetunimi";
            this.Lyhinetunimi.Size = new System.Drawing.Size(121, 23);
            this.Lyhinetunimi.TabIndex = 1;
            this.Lyhinetunimi.Text = "Etsi lyhin etunimi";
            this.Lyhinetunimi.UseVisualStyleBackColor = true;
            this.Lyhinetunimi.Click += new System.EventHandler(this.Lyhinetunimi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mies",
            "Nainen"});
            this.comboBox1.Location = new System.Drawing.Point(89, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // vastaus
            // 
            this.vastaus.Location = new System.Drawing.Point(89, 125);
            this.vastaus.Name = "vastaus";
            this.vastaus.Size = new System.Drawing.Size(121, 20);
            this.vastaus.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vastaus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lyhinetunimi);
            this.Controls.Add(this.Pisinetunimi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pisinetunimi;
        private System.Windows.Forms.Button Lyhinetunimi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox vastaus;
    }
}

