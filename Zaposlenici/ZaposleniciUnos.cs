using NuoDb.Data.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaposlenici
{
    public partial class ZaposleniciUnos : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        List<int> idList;
        int idZaposlenik;

        public ZaposleniciUnos()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idZaposlenik = 999;
        }

        public ZaposleniciUnos(int id)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idZaposlenik = id;
        }

        private void FillComboBox()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from pozicija";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                pozicijaCbox.Items.Clear();
                rdr = command.ExecuteReader();
                int i = 0;
                pozicijaCbox.DisplayMember = "Text";
                pozicijaCbox.ValueMember = "Value";
                idList = new List<int>();
                while (rdr.Read())
                {
                    pozicijaCbox.Items.Add(new { Text = rdr["naziv"].ToString(), Value = rdr["idpozicija"].ToString() });
                    idList.Add(int.Parse(rdr["idpozicija"].ToString()));
                }
                rdr.Close();
            }
            catch (NuoDbSqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void FillBoxes()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from zaposlenik join pozicija on zaposlenik.pozicija_idpozicija = pozicija.idpozicija where idzaposlenik = " + idZaposlenik + ";";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    imeTbox.Text = rdr["ime"].ToString();
                    prezimeTbox.Text = rdr["prezime"].ToString();
                    oibTbox.Text = rdr["oib"].ToString();
                    telbrojTbox.Text = rdr["telefonski_broj"].ToString();
                    adresaTbox.Text = rdr["adresa"].ToString();
                    brojracunaTbox.Text = rdr["broj_racuna"].ToString();
                    korimeTbox.Text = rdr["korisnicko_ime"].ToString();
                    lozinkaTbox.Text = rdr["lozinka"].ToString();
                    pozicijaCbox.Text = rdr[11].ToString();
                }
                rdr.Close();
            }
            catch (NuoDbSqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void ZaposleniciUnos_Load(object sender, EventArgs e)
        {
            FillComboBox();
            if (idZaposlenik != 999)
            {
                FillBoxes();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            double OIB;
            int telBroj;
            if (double.TryParse(oibTbox.Text, out OIB) && oibTbox.Text.Length == 11 && int.TryParse(telbrojTbox.Text, out telBroj) && pozicijaCbox.SelectedIndex >= 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    if (idZaposlenik == 999)
                    {
                        sqlQuery = "insert into zaposlenik values (default, '" + imeTbox.Text + "', '" + prezimeTbox.Text + "' " + ", '" + telBroj + "' " + ", '" + adresaTbox.Text + "', '" + OIB + "', '" + brojracunaTbox.Text + "', '" + korimeTbox.Text + "', '" + lozinkaTbox.Text + "'," + idList[pozicijaCbox.SelectedIndex] + " ); ";
                    }
                    else
                    {
                        sqlQuery = "update zaposlenik set ime = '" + imeTbox.Text + "', prezime = '" + prezimeTbox.Text + "', telefonski_broj = '" + telBroj + "', adresa = '" + adresaTbox.Text + "', oib = '" + OIB + "', broj_racuna = '" + brojracunaTbox.Text + "', korisnicko_ime = '" + korimeTbox.Text + "', lozinka = '" + lozinkaTbox.Text + "', pozicija_idpozicija = " + idList[pozicijaCbox.SelectedIndex] + " where idzaposlenik = " + idZaposlenik + ";";
                    }
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
            }
        }
    }
}
