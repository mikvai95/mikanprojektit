using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poiminta1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ekapilkku, tokapilkku, aikapituus, talteen = 0;
            DateTime saika, vanhoin;
            vanhoin = DateTime.Now;

            string[] henkilot = new string[10];
            henkilot[0] = "Jyri, Mies, 22.5.1965";
            henkilot[1] = "Sirpa, Nainen, 10.12.1965";
            henkilot[2] = "Jari, Mies, 21.6.1972";
            henkilot[3] = "Carita, Nainen, 3.9.1970";
            henkilot[4] = "Elja-Ilari, Mies, 13.4.1990";
            henkilot[5] = "Niclas, Mies, 8.12.1963";
            henkilot[6] = "Petteri, Mies, 28.10.1978";
            henkilot[7] = "Kirsi, Nainen, 4.5.1971";
            henkilot[8] = "Outi, Nainen, 29.4.1973";
            henkilot[9] = "Ilmari, Mies, 3.3.1933";
            for (int i = 0; i < henkilot.Length; i++)
            {
                ekapilkku = henkilot[i].IndexOf(",", 0);
                tokapilkku = henkilot[i].IndexOf(",", (ekapilkku + 1));
                aikapituus = henkilot[i].Length - tokapilkku;
                saika = Convert.ToDateTime(henkilot[i].Substring((tokapilkku + 2),(aikapituus-2)));
                //MessageBox.Show(saika+"");
                if (saika < vanhoin)
                {
                    vanhoin = saika;
                    talteen = i;
                }
            }
            vanhin.Text = henkilot[talteen];

        }
    }
}
