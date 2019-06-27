namespace Pankki
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
            this.talletusBoxi = new System.Windows.Forms.TextBox();
            this.ottoBoxi = new System.Windows.Forms.TextBox();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.teeTalletus = new System.Windows.Forms.Button();
            this.teeOtto = new System.Windows.Forms.Button();
            this.saldoNappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Handelsbanken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Talletukset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Otot";
            // 
            // talletusBoxi
            // 
            this.talletusBoxi.Location = new System.Drawing.Point(234, 76);
            this.talletusBoxi.Name = "talletusBoxi";
            this.talletusBoxi.Size = new System.Drawing.Size(100, 20);
            this.talletusBoxi.TabIndex = 3;
            // 
            // ottoBoxi
            // 
            this.ottoBoxi.Location = new System.Drawing.Point(234, 116);
            this.ottoBoxi.Name = "ottoBoxi";
            this.ottoBoxi.Size = new System.Drawing.Size(100, 20);
            this.ottoBoxi.TabIndex = 4;
            // 
            // saldoLabel
            // 
            this.saldoLabel.AutoSize = true;
            this.saldoLabel.Location = new System.Drawing.Point(138, 161);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(34, 13);
            this.saldoLabel.TabIndex = 5;
            this.saldoLabel.Text = "Saldo";
            // 
            // teeTalletus
            // 
            this.teeTalletus.Location = new System.Drawing.Point(350, 76);
            this.teeTalletus.Name = "teeTalletus";
            this.teeTalletus.Size = new System.Drawing.Size(75, 23);
            this.teeTalletus.TabIndex = 6;
            this.teeTalletus.Text = "Talletus";
            this.teeTalletus.UseVisualStyleBackColor = true;
            this.teeTalletus.Click += new System.EventHandler(this.teeTalletus_Click);
            // 
            // teeOtto
            // 
            this.teeOtto.Location = new System.Drawing.Point(350, 113);
            this.teeOtto.Name = "teeOtto";
            this.teeOtto.Size = new System.Drawing.Size(75, 23);
            this.teeOtto.TabIndex = 7;
            this.teeOtto.Text = "Otto";
            this.teeOtto.UseVisualStyleBackColor = true;
            this.teeOtto.Click += new System.EventHandler(this.teeOtto_Click);
            // 
            // saldoNappi
            // 
            this.saldoNappi.Location = new System.Drawing.Point(350, 156);
            this.saldoNappi.Name = "saldoNappi";
            this.saldoNappi.Size = new System.Drawing.Size(75, 23);
            this.saldoNappi.TabIndex = 8;
            this.saldoNappi.Text = "Näytä saldo";
            this.saldoNappi.UseVisualStyleBackColor = true;
            this.saldoNappi.Click += new System.EventHandler(this.saldoNappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saldoNappi);
            this.Controls.Add(this.teeOtto);
            this.Controls.Add(this.teeTalletus);
            this.Controls.Add(this.saldoLabel);
            this.Controls.Add(this.ottoBoxi);
            this.Controls.Add(this.talletusBoxi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pankkitili";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox talletusBoxi;
        private System.Windows.Forms.TextBox ottoBoxi;
        private System.Windows.Forms.Label saldoLabel;
        private System.Windows.Forms.Button teeTalletus;
        private System.Windows.Forms.Button teeOtto;
        private System.Windows.Forms.Button saldoNappi;
    }
}

