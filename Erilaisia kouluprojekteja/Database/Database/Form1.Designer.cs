namespace Database
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
            this.asiakasTaulukkoNakyma = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sukunimiBoxi = new System.Windows.Forms.TextBox();
            this.etunimiBoxi = new System.Windows.Forms.TextBox();
            this.lahiosoiteBoxi = new System.Windows.Forms.TextBox();
            this.postinumeroBoxi = new System.Windows.Forms.TextBox();
            this.postitoimipaikkaBoxi = new System.Windows.Forms.TextBox();
            this.PaivitaButton = new System.Windows.Forms.Button();
            this.TallennaButton = new System.Windows.Forms.Button();
            this.PoistaButton = new System.Windows.Forms.Button();
            this.NaytaPainike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasTaulukkoNakyma)).BeginInit();
            this.SuspendLayout();
            // 
            // asiakasTaulukkoNakyma
            // 
            this.asiakasTaulukkoNakyma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakasTaulukkoNakyma.Location = new System.Drawing.Point(594, 2);
            this.asiakasTaulukkoNakyma.Name = "asiakasTaulukkoNakyma";
            this.asiakasTaulukkoNakyma.Size = new System.Drawing.Size(756, 613);
            this.asiakasTaulukkoNakyma.TabIndex = 0;
            this.asiakasTaulukkoNakyma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiakasTaulukkoNakyma_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sukunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Etunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lähiosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postinumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postitoimipaikka";
            // 
            // sukunimiBoxi
            // 
            this.sukunimiBoxi.Location = new System.Drawing.Point(215, 111);
            this.sukunimiBoxi.Name = "sukunimiBoxi";
            this.sukunimiBoxi.Size = new System.Drawing.Size(100, 20);
            this.sukunimiBoxi.TabIndex = 6;
            // 
            // etunimiBoxi
            // 
            this.etunimiBoxi.Location = new System.Drawing.Point(215, 138);
            this.etunimiBoxi.Name = "etunimiBoxi";
            this.etunimiBoxi.Size = new System.Drawing.Size(100, 20);
            this.etunimiBoxi.TabIndex = 7;
            // 
            // lahiosoiteBoxi
            // 
            this.lahiosoiteBoxi.Location = new System.Drawing.Point(215, 169);
            this.lahiosoiteBoxi.Name = "lahiosoiteBoxi";
            this.lahiosoiteBoxi.Size = new System.Drawing.Size(100, 20);
            this.lahiosoiteBoxi.TabIndex = 8;
            // 
            // postinumeroBoxi
            // 
            this.postinumeroBoxi.Location = new System.Drawing.Point(215, 197);
            this.postinumeroBoxi.Name = "postinumeroBoxi";
            this.postinumeroBoxi.Size = new System.Drawing.Size(100, 20);
            this.postinumeroBoxi.TabIndex = 9;
            // 
            // postitoimipaikkaBoxi
            // 
            this.postitoimipaikkaBoxi.Location = new System.Drawing.Point(215, 223);
            this.postitoimipaikkaBoxi.Name = "postitoimipaikkaBoxi";
            this.postitoimipaikkaBoxi.Size = new System.Drawing.Size(100, 20);
            this.postitoimipaikkaBoxi.TabIndex = 10;
            // 
            // PaivitaButton
            // 
            this.PaivitaButton.Location = new System.Drawing.Point(129, 255);
            this.PaivitaButton.Name = "PaivitaButton";
            this.PaivitaButton.Size = new System.Drawing.Size(75, 23);
            this.PaivitaButton.TabIndex = 11;
            this.PaivitaButton.Text = "Päivitä";
            this.PaivitaButton.UseVisualStyleBackColor = true;
            this.PaivitaButton.Click += new System.EventHandler(this.PaivitaButton_Click);
            // 
            // TallennaButton
            // 
            this.TallennaButton.Location = new System.Drawing.Point(215, 255);
            this.TallennaButton.Name = "TallennaButton";
            this.TallennaButton.Size = new System.Drawing.Size(75, 23);
            this.TallennaButton.TabIndex = 12;
            this.TallennaButton.Text = "Tallenna";
            this.TallennaButton.UseVisualStyleBackColor = true;
            this.TallennaButton.Click += new System.EventHandler(this.TallennaButton_Click);
            // 
            // PoistaButton
            // 
            this.PoistaButton.Location = new System.Drawing.Point(305, 255);
            this.PoistaButton.Name = "PoistaButton";
            this.PoistaButton.Size = new System.Drawing.Size(75, 23);
            this.PoistaButton.TabIndex = 13;
            this.PoistaButton.Text = "Poista";
            this.PoistaButton.UseVisualStyleBackColor = true;
            this.PoistaButton.Click += new System.EventHandler(this.PoistaButton_Click);
            // 
            // NaytaPainike
            // 
            this.NaytaPainike.Location = new System.Drawing.Point(398, 255);
            this.NaytaPainike.Name = "NaytaPainike";
            this.NaytaPainike.Size = new System.Drawing.Size(75, 23);
            this.NaytaPainike.TabIndex = 14;
            this.NaytaPainike.Text = "Näytä";
            this.NaytaPainike.UseVisualStyleBackColor = true;
            this.NaytaPainike.Click += new System.EventHandler(this.NaytaPainike_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 617);
            this.Controls.Add(this.NaytaPainike);
            this.Controls.Add(this.PoistaButton);
            this.Controls.Add(this.TallennaButton);
            this.Controls.Add(this.PaivitaButton);
            this.Controls.Add(this.postitoimipaikkaBoxi);
            this.Controls.Add(this.postinumeroBoxi);
            this.Controls.Add(this.lahiosoiteBoxi);
            this.Controls.Add(this.etunimiBoxi);
            this.Controls.Add(this.sukunimiBoxi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asiakasTaulukkoNakyma);
            this.Name = "Form1";
            this.Text = "Tietokanta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asiakasTaulukkoNakyma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView asiakasTaulukkoNakyma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sukunimiBoxi;
        private System.Windows.Forms.TextBox etunimiBoxi;
        private System.Windows.Forms.TextBox lahiosoiteBoxi;
        private System.Windows.Forms.TextBox postinumeroBoxi;
        private System.Windows.Forms.TextBox postitoimipaikkaBoxi;
        private System.Windows.Forms.Button PaivitaButton;
        private System.Windows.Forms.Button TallennaButton;
        private System.Windows.Forms.Button PoistaButton;
        private System.Windows.Forms.Button NaytaPainike;
    }
}

