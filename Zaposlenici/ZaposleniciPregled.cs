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
    public partial class ZaposleniciPregled : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;

        public ZaposleniciPregled()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
        }

        private void ZaposleniciPregled_Load(object sender, EventArgs e)
        {
            GetZaposlenici();
        }

        private void GetZaposlenici()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from zaposlenik join pozicija on zaposlenik.pozicija_idpozicija = pozicija.idpozicija";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                zaposleniciDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["idzaposlenik"].ToString(), rdr["ime"].ToString(), rdr["prezime"].ToString(), rdr["telefonski_broj"].ToString(), rdr["adresa"].ToString(), rdr["oib"].ToString(), rdr["broj_racuna"].ToString(), rdr["korisnicko_ime"].ToString(), rdr["lozinka"].ToString(), rdr[11].ToString() };
                    zaposleniciDGV.Rows.Add(row);
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

        private void noviZaposlenikButton_Click(object sender, EventArgs e)
        {
            ZaposleniciUnos forma = new ZaposleniciUnos();
            forma.ShowDialog();
            GetZaposlenici();
        }

        private void izmjeniZaposlenikaButton_Click(object sender, EventArgs e)
        {
            if (zaposleniciDGV.SelectedRows.Count > 0)
            {
                ZaposleniciUnos forma = new ZaposleniciUnos(int.Parse(zaposleniciDGV.CurrentRow.Cells[0].Value.ToString()));
                forma.ShowDialog();
                GetZaposlenici();
            }
            else
            {
                MessageBox.Show("Nije odabran zaposlenik");
            }
        }

        private void obrisiZposlenikButton_Click(object sender, EventArgs e)
        {
            if (zaposleniciDGV.SelectedRows.Count > 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from zaposlenik where idzaposlenik = " + int.Parse(zaposleniciDGV.CurrentRow.Cells[0].Value.ToString()) + "";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Zaposlenik se ne može brisati dok se navodi na računima ili primkama");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                    GetZaposlenici();

                }
            }
            else
            {
                MessageBox.Show("Nije odabran zaposlenik");
            }
        }
    }
}
