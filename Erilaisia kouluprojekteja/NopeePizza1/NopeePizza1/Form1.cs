using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NopeePizza1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string tilaus, pizza, enimi, snimi, lsoite, pnro;
            pizza = pizzaBox.SelectedItem.ToString();
            enimi = enimiBox.Text;
            snimi = snimiBox.Text;
            lsoite = osoiteBox.Text;
            pnro = postiBox.Text;
            tilaus = "Tilaus:" + "\n" + enimi + " " + snimi + "\n" + lsoite + " " + pnro + "\n\n";
            KirjoitaTiedostoon(tilaus);
            PutsaaKaikki();

        }
        public void KirjoitaTiedostoon(string teksti)
        {
        using (StreamWriter muuttuja = File.AppendText("C:\\xampp\\htdocs\\pizzatilaus.xml"))
            {
            muuttuja.WriteLine(teksti);
            muuttuja.Close();
            }
        }
        public void PutsaaKaikki()
        {
            enimiBox.Clear();
            snimiBox.Clear();
            osoiteBox.Clear();
            postiBox.Clear();
            pizzaBox.Select();
            pizzaBox.SelectedIndex = -1;
            MessageBox.Show("Tilauksesi on lähetetty.");
        }
    }
}
