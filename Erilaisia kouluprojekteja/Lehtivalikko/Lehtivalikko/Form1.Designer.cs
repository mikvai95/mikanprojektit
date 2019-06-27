namespace Lehtivalikko
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
            this.valintaBoxi = new System.Windows.Forms.ComboBox();
            this.selain = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // valintaBoxi
            // 
            this.valintaBoxi.FormattingEnabled = true;
            this.valintaBoxi.Items.AddRange(new object[] {
            "Miehet",
            "Naiset",
            "Pojat",
            "Tytöt"});
            this.valintaBoxi.Location = new System.Drawing.Point(147, 27);
            this.valintaBoxi.Name = "valintaBoxi";
            this.valintaBoxi.Size = new System.Drawing.Size(121, 21);
            this.valintaBoxi.TabIndex = 0;
            this.valintaBoxi.SelectedIndexChanged += new System.EventHandler(this.valintaBoxi_SelectedIndexChanged);
            // 
            // selain
            // 
            this.selain.Location = new System.Drawing.Point(147, 81);
            this.selain.MinimumSize = new System.Drawing.Size(20, 20);
            this.selain.Name = "selain";
            this.selain.Size = new System.Drawing.Size(250, 250);
            this.selain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selain);
            this.Controls.Add(this.valintaBoxi);
            this.Name = "Form1";
            this.Text = "Lehtiä kaikille";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox valintaBoxi;
        private System.Windows.Forms.WebBrowser selain;
    }
}

