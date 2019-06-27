using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        /* MySqlDataAdapter tietoAdapteri;
         MySqlCommandBuilder uusi;
         DataTable tietotaulukko;*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BindGrid();
        }
        private void BindGrid()
        {
            string yhteysTeksti = "Server=localhost;Database=tuodut;uid=root;password=''";
            MySqlConnection yhteys = new MySqlConnection(yhteysTeksti);
            {
                using (MySqlCommand komento = new MySqlCommand("SELECT Jäsennro, Sukunimi, Etunimi, Lähiosoite, Postinro, Postitmpk FROM Jasenet", yhteys))
                {
                    komento.CommandType = CommandType.Text;
                    using (MySqlDataAdapter tietoAdapteri = new MySqlDataAdapter(komento))
                    {
                        using (DataTable tietotaulu = new DataTable())
                        {
                            tietoAdapteri.Fill(tietotaulu);
                            asiakasTaulukkoNakyma.DataSource = tietotaulu;
                        }
                    }
                }
            }
        }

        private void PaivitaButton_Click(object sender, EventArgs e)
        {
            string paivitys;
            int Jasen = Convert.ToInt32(asiakasTaulukkoNakyma.CurrentRow.Cells[0].Value);
            string etunimi = asiakasTaulukkoNakyma.CurrentRow.Cells[2].Value.ToString();
            paivitys = "update jasenet set Sukunimi=" + this.sukunimiBoxi.Text + ",Etunimi=" + this.etunimiBoxi.Text + ",Lähiosoite=" + this.lahiosoiteBoxi.Text + ",Postinro=" + this.postinumeroBoxi.Text + ",Postitmpk=" + this.postitoimipaikkaBoxi.Text + " where Jäsennro=" + Jasen + " AND Etunimi =" + etunimi + ";";
            // MessageBox.Show(Jasen+"");
            teeKysely(paivitys);
        }

        private void TallennaButton_Click(object sender, EventArgs e)
        {
            string lisays;
            lisays = "insert into jasenet (Etunimi, Sukunimi, Lahiosoite, Postinro, Postitmpk) values (" + "" + this.etunimiBoxi.Text + "" + "," + "" + this.sukunimiBoxi.Text + "" + "," + "" + this.lahiosoiteBoxi.Text + "" + "," + "" + this.postinumeroBoxi.Text + "" + "," + "" + this.postitoimipaikkaBoxi + "" + ");";
            // MessageBox.Show(lisays);
            teeKysely(lisays);
        }
        private void teeKysely(string kysely)
        {
            try
            {
                // Tämä on yhteyslauseke, jolla otetaan yhteystietokantaan.
                string yhteysrivi = "datasource=localhost;Database=tuodut;username=root;password=''";
                // Tässä on MySqlConnection komento, jolla luodaan yhteys-niminen objekti, jolle annetaan edellä luotu yhteysrivi-niminen yhteys string
                MySqlConnection yhteys = new MySqlConnection(yhteysrivi);
                //Alla on MySqlCommand -luokka, jolla käsitellään kysely, joka lähetetään stringinä eri nappien painalluksista.
                MySqlCommand komento = new MySqlCommand(kysely, yhteys);
                MySqlDataReader lukija;
                yhteys.Open();
                lukija = komento.ExecuteReader(); // Tässä kysely käynnistetään ja suoritetaan tietokannassa.
                MessageBox.Show("Tietoa käsitellään");
                while (lukija.Read())
                {
                }
                this.BindGrid();
                yhteys.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PoistaButton_Click(object sender, EventArgs e)
        {
            string poisto;
            int Jasen = Convert.ToInt32(asiakasTaulukkoNakyma.CurrentRow.Cells[0].Value);
            poisto = "delete from jasenet Where Jäsennro =" + Jasen + " AND Etunimi =" + this.etunimiBoxi.Text + ";";
            // MessageBox.Show(poisto);
            teeKysely(poisto);
        }

        private void NaytaPainike_Click(object sender, EventArgs e)
        {
            string nayta;
            nayta = "SELECT Sukunimi, Etunimi, Lähiosoite, Postinro, Postitmpk FROM Jasenet";
            teeKysely(nayta);
        }

        private void asiakasTaulukkoNakyma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sukunimiBoxi.Text = asiakasTaulukkoNakyma.CurrentRow.Cells[1].Value.ToString();
            etunimiBoxi.Text = asiakasTaulukkoNakyma.CurrentRow.Cells[2].Value.ToString();
            lahiosoiteBoxi.Text = asiakasTaulukkoNakyma.CurrentRow.Cells[3].Value.ToString();
            postinumeroBoxi.Text = asiakasTaulukkoNakyma.CurrentRow.Cells[4].Value.ToString();
            postitoimipaikkaBoxi.Text = asiakasTaulukkoNakyma.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
