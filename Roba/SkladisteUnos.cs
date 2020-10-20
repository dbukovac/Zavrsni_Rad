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
    public partial class SkladisteUnos : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        int idSkladiste;

        public SkladisteUnos()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idSkladiste = 999;
        }

        public SkladisteUnos(int id)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idSkladiste = id;
        }

        private void FillBoxes()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from skladiste where idskladiste = " + idSkladiste + ";";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    nazivTbox.Text = rdr["naziv"].ToString();
                    adresaTbox.Text = rdr["adresa"].ToString();
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

        private void SkladisteUnos_Load(object sender, EventArgs e)
        {
            if (idSkladiste != 999)
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
            try
            {
                connection.Open();
                string sqlQuery;
                if (idSkladiste == 999)
                {
                    sqlQuery = "insert into skladiste values (default, '" + nazivTbox.Text + "', '" + adresaTbox.Text + "' );";
                }
                else
                {
                    sqlQuery = "update skladiste set naziv = '" + nazivTbox.Text + "', adresa = '" + adresaTbox.Text + "' where idskladiste = " + idSkladiste + ";";
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

