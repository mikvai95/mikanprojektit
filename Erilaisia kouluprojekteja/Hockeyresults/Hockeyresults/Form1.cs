using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockeyresults
{
    public partial class Jääkiekkotulokset : Form
    {
        public Jääkiekkotulokset()
        {
            InitializeComponent();
        }

        private void Tulokset_Click(object sender, EventArgs e)
        {
            string koti = kotiBox.Text;
            string vieras = vierasBox.Text;
            int kotipisteet, vieraspisteet;
            int kpisteet = Convert.ToInt32(kotiValinta.Value);
            int vpisteet = Convert.ToInt32(vierasValinta.Value);
            if (kpisteet < 0 || vpisteet < 0)
            {
                kotipisteet = 0;
                vieraspisteet = 0;
                MessageBox.Show("Unohdit antaa maalien lukumäärän.");
            }
            else if (kpisteet == vpisteet)
            {
                kotipisteet = 1;
                vieraspisteet = 1;
            }
            else if(kpisteet > vpisteet)
            {
                kotipisteet = 3;
                vieraspisteet = 0;
            }
            else
            {
                kotipisteet = 0;
                vieraspisteet = 3;
            }
            MessageBox.Show("Ottelussa " + kotiBox.Text + " vastaan " + vierasBox.Text + " tulokseksi tuli " + kpisteet + " - " + vpisteet + ", pisteitä joukkueille tuli seuraavasti: koti: " + kotipisteet + " ja vieras: " + vieraspisteet);
        }
    }
}
