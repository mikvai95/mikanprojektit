namespace NopeePizza1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pizzaBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enimiBox = new System.Windows.Forms.TextBox();
            this.snimiBox = new System.Windows.Forms.TextBox();
            this.osoiteBox = new System.Windows.Forms.TextBox();
            this.postiBox = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(290, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pizzaBox
            // 
            this.pizzaBox.FormattingEnabled = true;
            this.pizzaBox.Items.AddRange(new object[] {
            "Margherita - Tomaattikastike, juusto",
            "Bolognese - Tomaattikastike, juusto, jauheliha",
            "Hawaii - Tomaattikastike, juusto, kinkku, ananas",
            "Americana - Tomaattikastike, juusto, kinkku, ananas, aurajuusto",
            "Opera - Tomaattikastike, juusto, kinkku, tonnikala, salami",
            "Mexicana - Tomaattikastike, juusto, salami, paprika, jalapeño",
            "Pollo - Tomaattikastike, juusto, kana, rucola",
            "Speciale - Tomaattikastike, juusto, salami, sipuli, valkosipuli",
            "Quatro Stagioni - Tomaattikastike, juusto, kinkku",
            "Fantasia - Tomaattikastike, juusto, omat valinnat"});
            this.pizzaBox.Location = new System.Drawing.Point(12, 196);
            this.pizzaBox.Name = "pizzaBox";
            this.pizzaBox.Size = new System.Drawing.Size(391, 21);
            this.pizzaBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(21, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(21, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lähiosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(21, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Postinro ja -toimipaikka";
            // 
            // enimiBox
            // 
            this.enimiBox.Location = new System.Drawing.Point(255, 251);
            this.enimiBox.Name = "enimiBox";
            this.enimiBox.Size = new System.Drawing.Size(189, 20);
            this.enimiBox.TabIndex = 7;
            // 
            // snimiBox
            // 
            this.snimiBox.Location = new System.Drawing.Point(255, 284);
            this.snimiBox.Name = "snimiBox";
            this.snimiBox.Size = new System.Drawing.Size(189, 20);
            this.snimiBox.TabIndex = 8;
            // 
            // osoiteBox
            // 
            this.osoiteBox.Location = new System.Drawing.Point(255, 319);
            this.osoiteBox.Name = "osoiteBox";
            this.osoiteBox.Size = new System.Drawing.Size(189, 20);
            this.osoiteBox.TabIndex = 9;
            // 
            // postiBox
            // 
            this.postiBox.Location = new System.Drawing.Point(255, 359);
            this.postiBox.Name = "postiBox";
            this.postiBox.Size = new System.Drawing.Size(189, 20);
            this.postiBox.TabIndex = 10;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(303, 408);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 11;
            this.sendbtn.Text = "Lähetä";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.postiBox);
            this.Controls.Add(this.osoiteBox);
            this.Controls.Add(this.snimiBox);
            this.Controls.Add(this.enimiBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pizzaBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "NopeePizza1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox pizzaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enimiBox;
        private System.Windows.Forms.TextBox snimiBox;
        private System.Windows.Forms.TextBox osoiteBox;
        private System.Windows.Forms.TextBox postiBox;
        private System.Windows.Forms.Button sendbtn;
    }
}

