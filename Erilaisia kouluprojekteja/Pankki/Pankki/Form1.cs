using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pankki
{
    public partial class Form1 : Form
    {
        Tili asiakas = new Tili();
        public Form1()
        {
            InitializeComponent();
        }
        private void teeTalletus_Click(object sender, EventArgs e)
        {
            asiakas.Talletukset = Convert.ToDouble(talletusBoxi.Text);
            talletusBoxi.Clear();
            saldoLabel.Text = Convert.ToString(asiakas.Saldo);
        }
        private void teeOtto_Click(object sender, EventArgs e)
        {
            asiakas.Otot = Convert.ToDouble(ottoBoxi.Text);
            ottoBoxi.Clear();
            saldoLabel.Text = Convert.ToString(asiakas.Saldo);
        }
        private void saldoNappi_Click(object sender, EventArgs e)
        {
            saldoLabel.Text = Convert.ToString(asiakas.Saldo);
        }
    }
    class Tili
    {
        double saldo, talletukset, otot;

        public Tili()
        {
            saldo = 0;
            talletukset = 0;
            otot = 0;
        }

        public double Saldo
        {
            set
            {
                saldo = value;
            }
            get
            {
                return saldo;
            }
        }
        public double Otot
        {
            set
            {
                otot = value;
                saldo = saldo - otot;
            }
            get
            {
                return saldo;
            }
        }
        public double Talletukset
        {
            set
            {
                talletukset = value;
                saldo = saldo + talletukset;
            }
            get
            {
                return saldo;
            }
        }
    }
}
