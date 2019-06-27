using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehtivalikko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valintaBoxi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uri Osoite;
            if (valintaBoxi.SelectedItem.ToString() == "Miehet")
            {
                Osoite = new Uri("http://gti.fi");
            }
            else if (valintaBoxi.SelectedItem.ToString() == "Naiset")
            {
                Osoite = new Uri("http://gloria.fi");
            }
            else if (valintaBoxi.SelectedItem.ToString() == "Pojat")
            {
                Osoite = new Uri("http://tiny.cc/iee75y");
            }
            else
            {
                Osoite = new Uri("http://akuankka.fi");
            }
            selain.Navigate(Osoite);
        } 
    }
}
