using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisinlyhin2
{
    public partial class Form1 : Form
    {
        string[] henkilot = new string[10];
        int poimi;
        string sukp;
        public Form1()
        {
            InitializeComponent();
        }
        public void henkiloista(string pituus, string sukupuoli)
        {
            string etunimi = "", puolisuku, lyhin = "hypercalifracilistic", pisin = "";
            int pilkku, pilkku2;
            henkilot[0] = "Jyri, Mies, 22.5.1965";
            henkilot[1] = "Sirpa, Nainen, 10.12.1965";
            henkilot[2] = "Kaj, Mies, 21.6.1972";
            henkilot[3] = "Carita, Nainen, 3.9.1970";
            henkilot[4] = "Elja-Ilari, Mies, 13.4.1990";
            henkilot[5] = "Niclas, Mies, 8.12.1963";
            henkilot[6] = "Petteri, Mies, 28.10.1978";
            henkilot[7] = "Kirsi, Nainen, 4.5.1971";
            henkilot[8] = "Outi, Nainen, 29.4.1973";
            henkilot[9] = "Ilmari, Mies, 3.3.1933";
            for (int i = 0; i < henkilot.Length; i++)
            {
                try
                {
                    sukupuoli = sukupuoli.Replace(" ", "");
                    pilkku = henkilot[i].IndexOf(',', 0);
                    pilkku2 = henkilot[i].IndexOf(',', (pilkku + 1));
                    etunimi = henkilot[i].Substring(0, pilkku);
                    puolisuku = henkilot[i].Substring((pilkku + 2), (pilkku2 - pilkku - 2));
                    if (pituus == "lyhin" && sukupuoli == puolisuku)
                    {
                        //MessageBox.Show("Hurraa");
                        if (etunimi.Length < lyhin.Length)
                        {
                            lyhin = etunimi;
                            poimi = i;
                        }
                    }
                    else if (pituus == "pisin" && sukupuoli == puolisuku)
                    {
                        if (etunimi.Length > pisin.Length)
                        {
                            pisin = etunimi;
                            poimi = i;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Valitse sukupuoli!");
                    comboBox1.Focus();
                    break;
                } //MessageBox.Show("Etsittävä sukupuoli on "+sukupuoli +"\nja etsittävä pituus on " + pituus + "\nja nykyinen sukupuoli on: " + puolisuku + "\nja i on " + poimi + "\nEtunimi on: " + etunimi + " ja sen pituus on :" + etunimi.Length + "\nlyhin on: " + lyhin + "ja sen pituus on: " + lyhin.Length + "ja pisin on: " + pisin + "ja sen pituus on: " + pisin.Length );
                try
                {
                    if (comboBox1.SelectedItem.ToString() == "Mies" || comboBox1.SelectedItem.ToString() == "Nainen")
                    {
                        vastaus.Text = "Etsimäsi henkilö on: \n" + henkilot[poimi];
                    }
                }
                catch { }
            }
        }

        private void Pisinetunimi_Click(object sender, EventArgs e)
        {
            try
            {
                sukp = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Et valinnut sukupuolta!");
            }
            henkiloista("pisin", sukp);
        }

        private void Lyhinetunimi_Click(object sender, EventArgs e)
        {
            try
            {
                sukp = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Et valinnut sukupuolta!");
            }
            henkiloista("lyhin", sukp);
        }
    }
}
