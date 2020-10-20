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
    public partial class Stavke_racunaUnos : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        int idracun;

        public Stavke_racunaUnos(int racun)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idracun = racun;
        }

        private void Stavke_racunaUnos_Load(object sender, EventArgs e)
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

        private void dodajRobuButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(kolicinaTbox.Text) <= int.Parse(robaDGV.CurrentRow.Cells[3].Value.ToString()) && robaDGV.SelectedRows.Count > 0 && int.Parse(kolicinaTbox.Text)> 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "insert into stavka_racuna values (" + idracun + "," + int.Parse(robaDGV.CurrentRow.Cells[0].Value.ToString()) + "," + int.Parse(kolicinaTbox.Text) + ")";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Ta roba već postoji na računu");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
            }
            else if(int.Parse(kolicinaTbox.Text) > int.Parse(robaDGV.CurrentRow.Cells[3].Value.ToString()))
            {
                MessageBox.Show("Nema dovoljno tražene robe");
            }
            else
            {
                MessageBox.Show("Nije odabrana roba");
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
