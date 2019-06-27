namespace Kirja
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
            this.label5 = new System.Windows.Forms.Label();
            this.kirjaBoxi = new System.Windows.Forms.TextBox();
            this.kirjailijaBoxi = new System.Windows.Forms.TextBox();
            this.hintaBoxi = new System.Windows.Forms.TextBox();
            this.varastoBoxi = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjakauppa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kirjan nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kirjailijan nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kpl varastossa";
            // 
            // kirjaBoxi
            // 
            this.kirjaBoxi.Location = new System.Drawing.Point(284, 54);
            this.kirjaBoxi.Name = "kirjaBoxi";
            this.kirjaBoxi.Size = new System.Drawing.Size(100, 20);
            this.kirjaBoxi.TabIndex = 5;
            // 
            // kirjailijaBoxi
            // 
            this.kirjailijaBoxi.Location = new System.Drawing.Point(284, 81);
            this.kirjailijaBoxi.Name = "kirjailijaBoxi";
            this.kirjailijaBoxi.Size = new System.Drawing.Size(100, 20);
            this.kirjailijaBoxi.TabIndex = 6;
            // 
            // hintaBoxi
            // 
            this.hintaBoxi.Location = new System.Drawing.Point(284, 108);
            this.hintaBoxi.Name = "hintaBoxi";
            this.hintaBoxi.Size = new System.Drawing.Size(100, 20);
            this.hintaBoxi.TabIndex = 7;
            // 
            // varastoBoxi
            // 
            this.varastoBoxi.Location = new System.Drawing.Point(284, 135);
            this.varastoBoxi.Name = "varastoBoxi";
            this.varastoBoxi.Size = new System.Drawing.Size(100, 20);
            this.varastoBoxi.TabIndex = 8;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(208, 175);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Syötä tiedot";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(305, 174);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 10;
            this.ShowButton.Text = "Näytä tiedot";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(208, 224);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(217, 214);
            this.listBox.TabIndex = 11;
            this.listBox.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.varastoBoxi);
            this.Controls.Add(this.hintaBoxi);
            this.Controls.Add(this.kirjailijaBoxi);
            this.Controls.Add(this.kirjaBoxi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kirjat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kirjaBoxi;
        private System.Windows.Forms.TextBox kirjailijaBoxi;
        private System.Windows.Forms.TextBox hintaBoxi;
        private System.Windows.Forms.TextBox varastoBoxi;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ListView listBox;
    }
}

