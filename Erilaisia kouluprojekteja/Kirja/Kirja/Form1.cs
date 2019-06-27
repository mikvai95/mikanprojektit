using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kirja kirja;
        private void InsertButton_Click(object sender, EventArgs e)
        {
            string kirjannimi = kirjaBoxi.Text;
            string kirjailijannimi = kirjailijaBoxi.Text;
            decimal hinta = 0.0m;
            string varasto = varastoBoxi.Text;
            
            if(!string.IsNullOrWhiteSpace(kirjannimi) && !string.IsNullOrWhiteSpace(kirjailijannimi) && decimal.TryParse
                (hintaBoxi.Text, out hinta) &&  !string.IsNullOrWhiteSpace(varasto))
            {
                kirja = new Kirja(kirjannimi, kirjailijannimi, hinta, varasto);
            }
            else
            {
                MessageBox.Show("Ole hyvä ja anna tiedot.");
            }

        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                listBox.Items.Add("Kirjan nimi: " + kirja.Kirjannimi);
                listBox.Items.Add("Kirjailijan nimi: " + kirja.Kirjailijannimi);
                listBox.Items.Add("Kirjan hinta: " + kirja.Hinta);
                listBox.Items.Add("Määrä varastossa: " + kirja.Varasto);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Anna kirjan tiedot ensin!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class Kirja
    {
        public Kirja(string kirjannimi, string kirjailijannimi, decimal hinta, string varasto)
        {
            Kirjannimi = kirjannimi;
            Kirjailijannimi = kirjailijannimi;
            Hinta = hinta;
            Varasto = varasto;
        }
        
        public string Kirjannimi { get; set; }
        public string Kirjailijannimi { get; set; }
        public decimal Hinta { get; set; }
        public string Varasto { get; set; }
    }
}
