using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "=";
            button1.Text = "Laske";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            float a, b, c;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);
            if (comboBox1.Text == "+")
            {
                c = a + b;
                textBox4.Text = c.ToString();
            }

            else if (comboBox1.Text == "-")

            {
                c = a - b;
                textBox4.Text = c.ToString();
            }

            else if (comboBox1.Text == "*")

            {
                c = a * b;
                textBox4.Text = c.ToString();
            }

            else

            {
                c = a / b;
            }
        }
    }
}
