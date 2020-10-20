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
    public partial class SkladistePregled : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;

        public SkladistePregled()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
        }

        private void SkladistePregled_Load(object sender, EventArgs e)
        {
            GetSkladiste();
        }

        private void GetSkladiste()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from skladiste";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                skladisteDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["idskladiste"].ToString(), rdr["naziv"].ToString(), rdr["adresa"].ToString() };
                    skladisteDGV.Rows.Add(row);
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

        private void obrisiSkladisteButton_Click(object sender, EventArgs e)
        {
            if (skladisteDGV.SelectedRows.Count > 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from skladiste where idskladiste = " + int.Parse(skladisteDGV.CurrentRow.Cells[0].Value.ToString()) + "";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Skladište se ne može brisati dok se koristi za robu");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();

                    GetSkladiste();
                }
            }
            else
            {
                MessageBox.Show("Nije odabrano skladiste");
            }
        }

        private void novoSkladisteButton_Click(object sender, EventArgs e)
        {
            SkladisteUnos forma = new SkladisteUnos();
            forma.ShowDialog();
            GetSkladiste();
        }

        private void izmjeniSkladisteButton_Click(object sender, EventArgs e)
        {
            if (skladisteDGV.SelectedRows.Count > 0)
            {
                SkladisteUnos forma = new SkladisteUnos(int.Parse(skladisteDGV.CurrentRow.Cells[0].Value.ToString()));
                forma.ShowDialog();
                GetSkladiste();
            }
            else
            {
                MessageBox.Show("Nije odabrano skladište");
            }
        }
    }
}
