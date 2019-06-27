using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Tietokantayhteys3
{
    public partial class Form1 : Form
    {
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
                using (MySqlCommand komento = new MySqlCommand("SELECT Sukunimi, Etunimi, Lähiosoite, Postinro, Postitmpk FROM Jasenet", yhteys))
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
    }
}
