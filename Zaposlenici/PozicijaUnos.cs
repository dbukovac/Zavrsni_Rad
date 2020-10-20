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
    public partial class PozicijaUnos : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        int idPozicija;

        public PozicijaUnos()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idPozicija = 999;
        }

        public PozicijaUnos(int id)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idPozicija = id;
        }

        private void FillBoxes()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from pozicija where idpozicija = " + idPozicija + ";";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    nazivTbox.Text = rdr["naziv"].ToString();
                    opisTbox.Text = rdr["opis"].ToString();
                    razinaTbox.Text = rdr["razina_prava"].ToString();
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

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sqlQuery;
                if (idPozicija == 999)
                {
                    sqlQuery = "insert into pozicija values (default, '" + nazivTbox.Text + "', '" + opisTbox.Text + "' " + ", " + razinaTbox.Text + " ); ";
                }
                else
                {
                    sqlQuery = "update pozicija set naziv = '" + nazivTbox.Text + "', opis = '" + opisTbox.Text + "', razina_prava = " + razinaTbox.Text + " where idpozicija = " + idPozicija + ";";
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

        private void PozicijaUnos_Load(object sender, EventArgs e)
        {
            if (idPozicija != 999)
            {
                FillBoxes();
            }
        }
    }
}
