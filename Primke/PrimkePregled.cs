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

namespace Primke
{
    public partial class PrimkePregled : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        int idzaposlenik;
        List<int> idList;

        public PrimkePregled(int zap)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idzaposlenik = zap;
        }

        private void FillComboBox()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from poslovni_partner where tip_partnera_idtip_partnera = 1";
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

        private void PrimkePregled_Load(object sender, EventArgs e)
        {
            GetPrimke();
        }

        private void GetPrimke()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from primka join zaposlenik on primka.zaposlenik_idzaposlenik = zaposlenik.idzaposlenik join poslovni_partner on primka.poslovni_partner_idposlovni_partner = poslovni_partner.idposlovni_partner;";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                primkaDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["idprimka"].ToString(), rdr["datum_zaprimanja"].ToString(), rdr["kontrola"].ToString(), rdr[12].ToString(), rdr[16].ToString() };
                    primkaDGV.Rows.Add(row);
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
                if (primkaDGV.SelectedRows.Count > 0)
                {
                    connection.Open();
                    string sqlQuery = "select * from stavka_primka join roba on stavka_primka.roba_idroba = roba.idroba where stavka_primka.primka_idprimka = " + int.Parse(primkaDGV.CurrentRow.Cells[0].Value.ToString())+";";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    stavkaDGV.Rows.Clear();
                    rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        string[] row = new string[] { rdr["idroba"].ToString(), rdr["naziv"].ToString(), rdr["opis"].ToString(), rdr[2].ToString() };
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

        private void primkaDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(primkaDGV.SelectedRows.Count > 0)
            {
                GetStavke();
            }
        }

        private void primkaDGV_SelectionChanged_1(object sender, EventArgs e)
        {
            if (primkaDGV.SelectedRows.Count > 0)
            {
                GetStavke();
            }
        }

        private void partneriCbox_Click(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void obrisiPrimkuButton_Click(object sender, EventArgs e)
        {
            if (primkaDGV.SelectedRows.Count > 0 && int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from primka where idprimka = " + int.Parse(primkaDGV.CurrentRow.Cells[0].Value.ToString()) + "";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Primka se ne može brisati dok ima stavke");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                    GetPrimke();

                }
            }
            else if (int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 1)
            {
                MessageBox.Show("Primka je zaključana i ne može se mijenjati");
            }
            else
            {
                MessageBox.Show("Nije odabrana primka");
            }
        }

        private void obrisiStavkubutton_Click(object sender, EventArgs e)
        {
            if (primkaDGV.SelectedRows.Count > 0 && int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 0 && stavkaDGV.SelectedRows.Count > 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from stavka_primka where primka_idprimka = " + int.Parse(primkaDGV.CurrentRow.Cells[0].Value.ToString()) + " and roba_idroba = " + int.Parse(stavkaDGV.CurrentRow.Cells[0].Value.ToString()) + "";
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
            else if (int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 1)
            {
                MessageBox.Show("Primka je zaključana i ne može se mijenjati");
            }
            else
            {
                MessageBox.Show("Nije odabrana primka");
            }
        }

        private void izdajPrimkuButton_Click(object sender, EventArgs e)
        {
            if (primkaDGV.SelectedRows.Count > 0 && int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "update primka set kontrola = 1 where idprimka = " + int.Parse(primkaDGV.CurrentRow.Cells[0].Value.ToString()) + "";
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
                    GetPrimke();

                }
            }
            else if (int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 1)
            {
                MessageBox.Show("Primka je već zaključana");
            }
            else
            {
                MessageBox.Show("Nije odabrana primka");
            }
        }

        private void otkljucajPrimkuButton_Click(object sender, EventArgs e)
        {
            if (primkaDGV.SelectedRows.Count > 0 && int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 1)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "update primka set kontrola = 0 where idprimka = " + int.Parse(primkaDGV.CurrentRow.Cells[0].Value.ToString()) + "";
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
                    GetPrimke();

                }
            }
            else if (int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 0)
            {
                MessageBox.Show("Primka je već otključana");
            }
            else
            {
                MessageBox.Show("Nije odabrana primka");
            }
        }

        private void dodajPrimkuButton_Click(object sender, EventArgs e)
        {
            if (partneriCbox.SelectedIndex >= 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "insert into primka values (default, '" + DateTime.Today.ToString("dd/MM/yyyy") + "', 0, " + idzaposlenik + ", " + idList[partneriCbox.SelectedIndex] + " ); ";
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
                    GetPrimke();
                }
            }
            else
            {
                MessageBox.Show("Nije odabran partner");
            }
        }

        private void dodajStavkuButton_Click(object sender, EventArgs e)
        {
            if (primkaDGV.SelectedRows.Count > 0 && int.Parse(primkaDGV.CurrentRow.Cells[2].Value.ToString()) == 0)
            {
                Stavke_primkeUnos forma = new Stavke_primkeUnos(int.Parse(primkaDGV.CurrentRow.Cells[0].Value.ToString()));
                forma.ShowDialog();
                GetPrimke();
            }
            else
            {
                MessageBox.Show("Primka je zaključana");
            }
        }
    }
}
