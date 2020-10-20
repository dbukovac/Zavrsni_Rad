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
    public partial class PozicijaPregled : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;

        public PozicijaPregled()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
        }

        private void PozicijaPregled_Load(object sender, EventArgs e)
        {
            GetPozicija();
        }

        private void GetPozicija()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from pozicija";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                pozicijaDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["idpozicija"].ToString(), rdr["naziv"].ToString(), rdr["opis"].ToString(), rdr["razina_prava"].ToString() };
                    pozicijaDGV.Rows.Add(row);
                }
                rdr.Close();
            }
            catch (NuoDbSqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                MessageBox.Show("Pozicija se ne može brisati dok se koristi za zaposlenika");
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void novaPozicijaButton_Click(object sender, EventArgs e)
        {
            PozicijaUnos forma = new PozicijaUnos();
            forma.ShowDialog();
            GetPozicija();
        }

        private void izmjenipozicijuButton_Click(object sender, EventArgs e)
        {
            if (pozicijaDGV.SelectedRows.Count > 0)
            {
                PozicijaUnos forma = new PozicijaUnos(int.Parse(pozicijaDGV.CurrentRow.Cells[0].Value.ToString()));
                forma.ShowDialog();
                GetPozicija();
            }
            else
            {
                MessageBox.Show("Nije odabrana pozicija");
            }
        }

        private void obrisiPozicijuButton_Click(object sender, EventArgs e)
        {
            if (pozicijaDGV.SelectedRows.Count > 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from pozicija where idpozicija = " + int.Parse(pozicijaDGV.CurrentRow.Cells[0].Value.ToString()) + "";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Pozicija se ne može brisati dok se koristi za zaposlenika");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                    GetPozicija();

                }
            }
            else
            {
                MessageBox.Show("Nije odabrana pozicija");
            }
        }
    }
}
