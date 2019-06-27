namespace Hockeyresults
{
    partial class Jääkiekkotulokset
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
            this.Kotijoukkue = new System.Windows.Forms.Label();
            this.Vierasjoukkue = new System.Windows.Forms.Label();
            this.kotiBox = new System.Windows.Forms.TextBox();
            this.vierasBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kotiValinta = new System.Windows.Forms.NumericUpDown();
            this.vierasValinta = new System.Windows.Forms.NumericUpDown();
            this.Tulokset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kotiValinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vierasValinta)).BeginInit();
            this.SuspendLayout();
            // 
            // Kotijoukkue
            // 
            this.Kotijoukkue.AutoSize = true;
            this.Kotijoukkue.Location = new System.Drawing.Point(52, 55);
            this.Kotijoukkue.Name = "Kotijoukkue";
            this.Kotijoukkue.Size = new System.Drawing.Size(63, 13);
            this.Kotijoukkue.TabIndex = 0;
            this.Kotijoukkue.Text = "Kotijoukkue";
            // 
            // Vierasjoukkue
            // 
            this.Vierasjoukkue.AutoSize = true;
            this.Vierasjoukkue.Location = new System.Drawing.Point(55, 83);
            this.Vierasjoukkue.Name = "Vierasjoukkue";
            this.Vierasjoukkue.Size = new System.Drawing.Size(74, 13);
            this.Vierasjoukkue.TabIndex = 1;
            this.Vierasjoukkue.Text = "Vierasjoukkue";
            // 
            // kotiBox
            // 
            this.kotiBox.Location = new System.Drawing.Point(154, 55);
            this.kotiBox.Name = "kotiBox";
            this.kotiBox.Size = new System.Drawing.Size(172, 20);
            this.kotiBox.TabIndex = 2;
            // 
            // vierasBox
            // 
            this.vierasBox.Location = new System.Drawing.Point(154, 83);
            this.vierasBox.Name = "vierasBox";
            this.vierasBox.Size = new System.Drawing.Size(172, 20);
            this.vierasBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maalit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maalit";
            // 
            // kotiValinta
            // 
            this.kotiValinta.Location = new System.Drawing.Point(508, 55);
            this.kotiValinta.Name = "kotiValinta";
            this.kotiValinta.Size = new System.Drawing.Size(120, 20);
            this.kotiValinta.TabIndex = 6;
            // 
            // vierasValinta
            // 
            this.vierasValinta.Location = new System.Drawing.Point(508, 83);
            this.vierasValinta.Name = "vierasValinta";
            this.vierasValinta.Size = new System.Drawing.Size(120, 20);
            this.vierasValinta.TabIndex = 7;
            // 
            // Tulokset
            // 
            this.Tulokset.Location = new System.Drawing.Point(311, 137);
            this.Tulokset.Name = "Tulokset";
            this.Tulokset.Size = new System.Drawing.Size(160, 24);
            this.Tulokset.TabIndex = 8;
            this.Tulokset.Text = "Tulokset";
            this.Tulokset.UseVisualStyleBackColor = true;
            this.Tulokset.Click += new System.EventHandler(this.Tulokset_Click);
            // 
            // Jääkiekkotulokset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tulokset);
            this.Controls.Add(this.vierasValinta);
            this.Controls.Add(this.kotiValinta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vierasBox);
            this.Controls.Add(this.kotiBox);
            this.Controls.Add(this.Vierasjoukkue);
            this.Controls.Add(this.Kotijoukkue);
            this.Name = "Jääkiekkotulokset";
            this.Text = "Jääkiekkotulokset";
            ((System.ComponentModel.ISupportInitialize)(this.kotiValinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vierasValinta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kotijoukkue;
        private System.Windows.Forms.Label Vierasjoukkue;
        private System.Windows.Forms.TextBox kotiBox;
        private System.Windows.Forms.TextBox vierasBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown kotiValinta;
        private System.Windows.Forms.NumericUpDown vierasValinta;
        private System.Windows.Forms.Button Tulokset;
    }
}

