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

namespace Roba
{
    public partial class RobaPregled : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;

        public RobaPregled()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
        }

        private void RobaPregled_Load(object sender, EventArgs e)
        {
            GetRoba();
        }

        private void GetRoba()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from roba join skladiste on roba.skladiste_idskladiste = skladiste.idskladiste;";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                robaDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["idroba"].ToString(), rdr["naziv"].ToString(), rdr["jedinicna_cijena"].ToString(), rdr["kolicina"].ToString(), rdr["opis"].ToString(), rdr[7].ToString() };
                    robaDGV.Rows.Add(row);
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

        private void obrisiRobuButton_Click(object sender, EventArgs e)
        {
            if (robaDGV.SelectedRows.Count > 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from roba where idroba = " + int.Parse(robaDGV.CurrentRow.Cells[0].Value.ToString()) + "";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Roba se ne može brisati dok se navodi na stavkama");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                    GetRoba();
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana roba");
            }
        }

        private void novaRobaButton_Click(object sender, EventArgs e)
        {
            RobaUnos forma = new RobaUnos();
            forma.ShowDialog();
            GetRoba();
        }

        private void izmjeniRobuButton_Click(object sender, EventArgs e)
        {
            if (robaDGV.SelectedRows.Count > 0)
            {
                RobaUnos forma = new RobaUnos(int.Parse(robaDGV.CurrentRow.Cells[0].Value.ToString()));
                forma.ShowDialog();
                GetRoba();
            }
            else
            {
                MessageBox.Show("Nije odabrana roba");
            }
        }
    }
}
