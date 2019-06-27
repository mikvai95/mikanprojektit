using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kirjailija kirjailija;
        private void ShowButton_Click(object sender, EventArgs e)
        {
            string nimi = nimiBoxi.Text;
            string email = emailBoxi.Text;
            string sukupuoli = sukupuoliBoxi.Text;

            if (!string.IsNullOrWhiteSpace(nimi) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(sukupuoli))
            {
                kirjailija = new Kirjailija(nimi, email, sukupuoli);
            }
            else
            {
                MessageBox.Show("Et täyttänyt kaikkia kohtia!");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            nimiLista.Items.Add("Kirjailijan nimi: " + kirjailija.Nimi);
            nimiLista.Items.Add("Kirjailijan email: " + kirjailija.Email);
            nimiLista.Items.Add("Kirjailijan sukupuoli : " + kirjailija.Sukupuoli);
        }
    }
    class Kirjailija
    {

        public Kirjailija(string nimi, string email, string sukupuoli)
        {
            try
            {
                Nimi = nimi;
                Email = email;
                Sukupuoli = sukupuoli;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Anna kirjailijan tiedot ensin!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Nimi { get; set; }
        public string Email { get; set; }
        public string Sukupuoli { get; set; }
    }
}
