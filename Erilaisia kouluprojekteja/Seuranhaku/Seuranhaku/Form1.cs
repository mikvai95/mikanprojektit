using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seuranhaku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ika = int.Parse(textBox2.Text);
        if (ika >= 15 && ika <= 20)
        {
            MessageBox.Show("Hei " + textBox1.Text + "! Ohjaamme sinut nuorisoklubiin.");
        }
        else if (ika >= 21 && ika <= 39)
        {
            MessageBox.Show("Hei " + textBox1.Text + "! Ohjaamme sinut nuorten aikuisten klubiin.");
        }
        else if (ika >= 40 && ika <= 59)
        {
            MessageBox.Show("Hei " + textBox1.Text + "! Ohjaamme sinut Swingers-klubiin.");
        }
        else if (ika >= 60)
        {
            MessageBox.Show("Hei " + textBox1.Text + "! Ohjaamme sinut senioriklubiin.");
        }
        else
        {
            MessageBox.Show("Hei " + textBox1.Text + "! Pahoittelemme, mutta nämä sivut ovat K-15.");
        }
        
        }

    }
}
