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

namespace Racuni
{
    public partial class RacuniPregled : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        int idzaposlenik;
        List<int> idList;

        public RacuniPregled(int zap)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idzaposlenik = zap;
        }

        private void RacuniPregled_Load(object sender, EventArgs e)
        {
            GetRacuni();
        }
        private void FillComboBox()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from poslovni_partner where tip_partnera_idtip_partnera = 2";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                partneriCbox.Items.Clear();
                rdr = command.ExecuteReader();
                partneriCbox.DisplayMember = "Text";
                partneriCbox.ValueMember = "Value";
                idList = new List<int>();
                while (rdr.Read())
                {
                    partneriCbox.Items.Add(new { Text = rdr["naziv"].ToString(), Value = rdr["idposlovni_partner"].ToString() });
                    idList.Add(int.Parse(rdr["idposlovni_partner"].ToString()));
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

        private void GetRacuni()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from racun join zaposlenik on racun.zaposlenik_idzaposlenik = zaposlenik.idzaposlenik join poslovni_partner on racun.poslovni_partner_idposlovni_partner = poslovni_partner.idposlovni_partner;";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                racuniDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["idracun"].ToString(), rdr["datum_izdavanja"].ToString(), rdr["ukupna_cijena"].ToString(), rdr["kontrola"].ToString(), rdr[7].ToString(), rdr[17].ToString() };
                    racuniDGV.Rows.Add(row);
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
        private void GetStavke()
        {
            try
            {
                if (racuniDGV.SelectedRows.Count > 0)
                {
                    connection.Open();
                    string sqlQuery = "select * from stavka_racuna join roba on stavka_racuna.roba_idroba = roba.idroba where stavka_racuna.racun_idracun = " + int.Parse(racuniDGV.CurrentRow.Cells[0].Value.ToString());
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    stavkaDGV.Rows.Clear();
                    rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        decimal cijena = decimal.Parse(rdr["jedinicna_cijena"].ToString());
                        int kolicina = int.Parse(rdr[2].ToString());
                        decimal uk_cijena = cijena * kolicina;
                        string[] row = new string[] { rdr["idroba"].ToString(), rdr["naziv"].ToString(), rdr["opis"].ToString(), rdr["jedinicna_cijena"].ToString(), rdr[2].ToString(), uk_cijena.ToString() };
                        stavkaDGV.Rows.Add(row);
                    }
                    rdr.Close();
                }
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

        private void racuniDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (racuniDGV.SelectedRows.Count > 0)
            {
                GetStavke();
            }
        }

        private void obrisiRacunButton_Click(object sender, EventArgs e)
        {
            if (racuniDGV.SelectedRows.Count > 0 && int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from racun where idracun = " + int.Parse(racuniDGV.CurrentRow.Cells[0].Value.ToString()) + "";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Račun se ne može brisati dok ima stavke");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                    GetRacuni();

                }
            }
            else if(int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 1)
            {
                MessageBox.Show("Račun je izdan i ne može se mijenjati");
            }
            else
            {
                MessageBox.Show("Nije odabran račun");
            }
        }

        private void obrisiStavkubutton_Click(object sender, EventArgs e)
        {
            if (racuniDGV.SelectedRows.Count > 0 && int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 0 && stavkaDGV.SelectedRows.Count > 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from stavka_racuna where racun_idracun = " + int.Parse(racuniDGV.CurrentRow.Cells[0].Value.ToString()) + " and roba_idroba = "+ int.Parse(stavkaDGV.CurrentRow.Cells[0].Value.ToString()) + "";
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
                    GetStavke();

                }
            }
            else if (int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 1)
            {
                MessageBox.Show("Račun je izdan i ne može se mijenjati");
            }
            else
            {
                MessageBox.Show("Nije odabran račun");
            }
        }

        private void izdajRacunButton_Click(object sender, EventArgs e)
        {
            if (racuniDGV.SelectedRows.Count > 0 && int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "update racun set kontrola = 1 where idracun = " + int.Parse(racuniDGV.CurrentRow.Cells[0].Value.ToString()) + "";
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
                    GetRacuni();

                }
            }
            else if (int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 1)
            {
                MessageBox.Show("Račun je već zaključan");
            }
            else
            {
                MessageBox.Show("Nije odabran račun");
            }
        }

        private void otkljucajRacunButton_Click(object sender, EventArgs e)
        {
            if (racuniDGV.SelectedRows.Count > 0 && int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 1)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "update racun set kontrola = 0 where idracun = " + int.Parse(racuniDGV.CurrentRow.Cells[0].Value.ToString()) + "";
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
                    GetRacuni();

                }
            }
            else if(int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 0)
            {
                MessageBox.Show("Račun je već otključan");
            }
            else
            {
                MessageBox.Show("Nije odabran račun");
            }
        }

        private void dodajRacunButton_Click(object sender, EventArgs e)
        {
            if (partneriCbox.SelectedIndex >= 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "insert into racun values (default, '" + DateTime.Today.ToString("dd/MM/yyyy") + "', 0 , 0, " + idList[partneriCbox.SelectedIndex] + ", " + idzaposlenik + " ); ";
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
                    GetRacuni();
                }
            }
        }

        private void partneriCbox_Click(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void dodajStavkuButton_Click(object sender, EventArgs e)
        {
            if (racuniDGV.SelectedRows.Count > 0 && int.Parse(racuniDGV.CurrentRow.Cells[3].Value.ToString()) == 0)
            {
                Stavke_racunaUnos forma = new Stavke_racunaUnos(int.Parse(racuniDGV.CurrentRow.Cells[0].Value.ToString()));
                forma.ShowDialog();
                GetRacuni();
            }
            else
            {
                MessageBox.Show("Račun je zaključan");
            }
        }
    }
}
