namespace Writer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nimiBoxi = new System.Windows.Forms.TextBox();
            this.emailBoxi = new System.Windows.Forms.TextBox();
            this.sukupuoliBoxi = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.nimiLista = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjailijan tiedot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sukupuoli";
            // 
            // nimiBoxi
            // 
            this.nimiBoxi.Location = new System.Drawing.Point(273, 44);
            this.nimiBoxi.Name = "nimiBoxi";
            this.nimiBoxi.Size = new System.Drawing.Size(153, 20);
            this.nimiBoxi.TabIndex = 4;
            // 
            // emailBoxi
            // 
            this.emailBoxi.Location = new System.Drawing.Point(273, 74);
            this.emailBoxi.Name = "emailBoxi";
            this.emailBoxi.Size = new System.Drawing.Size(153, 20);
            this.emailBoxi.TabIndex = 5;
            // 
            // sukupuoliBoxi
            // 
            this.sukupuoliBoxi.Location = new System.Drawing.Point(273, 109);
            this.sukupuoliBoxi.Name = "sukupuoliBoxi";
            this.sukupuoliBoxi.Size = new System.Drawing.Size(153, 20);
            this.sukupuoliBoxi.TabIndex = 6;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(218, 155);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Syötä";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(314, 155);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 8;
            this.DisplayButton.Text = "Näytä";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // nimiLista
            // 
            this.nimiLista.Location = new System.Drawing.Point(174, 203);
            this.nimiLista.Name = "nimiLista";
            this.nimiLista.Size = new System.Drawing.Size(344, 218);
            this.nimiLista.TabIndex = 9;
            this.nimiLista.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nimiLista);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.sukupuoliBoxi);
            this.Controls.Add(this.emailBoxi);
            this.Controls.Add(this.nimiBoxi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kirjailija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nimiBoxi;
        private System.Windows.Forms.TextBox emailBoxi;
        private System.Windows.Forms.TextBox sukupuoliBoxi;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.ListView nimiLista;
    }
}

