namespace Potenssi1
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
            this.Laske = new System.Windows.Forms.Button();
            this.potenssiBoxi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(223, 52);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(174, 23);
            this.Laske.TabIndex = 0;
            this.Laske.Text = "Laske potenssit";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // potenssiBoxi
            // 
            this.potenssiBoxi.FormattingEnabled = true;
            this.potenssiBoxi.Location = new System.Drawing.Point(223, 91);
            this.potenssiBoxi.Name = "potenssiBoxi";
            this.potenssiBoxi.Size = new System.Drawing.Size(174, 21);
            this.potenssiBoxi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.potenssiBoxi);
            this.Controls.Add(this.Laske);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.ComboBox potenssiBoxi;
    }
}

