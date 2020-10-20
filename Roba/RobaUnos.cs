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
    public partial class RobaUnos : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        List<int> idList;
        int idRoba;

        public RobaUnos()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idRoba = 999;
        }

        public RobaUnos(int id)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idRoba = id;
        }

        private void RobaUnos_Load(object sender, EventArgs e)
        {
            FillComboBox();
            if(idRoba != 999)
            {
                FillBoxes();
            }
        }

        private void FillComboBox()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from skladiste";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                skladisteCbox.Items.Clear();
                rdr = command.ExecuteReader();
                int i = 0;
                skladisteCbox.DisplayMember = "Text";
                skladisteCbox.ValueMember = "Value";
                idList = new List<int>();
                while (rdr.Read())
                {
                    skladisteCbox.Items.Add(new { Text = rdr["naziv"].ToString(), Value = rdr["idskladiste"].ToString() });
                    idList.Add(int.Parse(rdr["idskladiste"].ToString()));
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
                string sqlQuery = "select * from roba join skladiste on roba.skladiste_idskladiste = skladiste.idskladiste where idroba = " + idRoba + ";";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    nazivTbox.Text = rdr["naziv"].ToString();
                    jedcijenaTbox.Text = rdr["jedinicna_cijena"].ToString();
                    opisTbox.Text = rdr["opis"].ToString();
                    skladisteCbox.Text = rdr[7].ToString();
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
            decimal jed_cijena;
            if (decimal.TryParse(jedcijenaTbox.Text, out jed_cijena))
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    if (idRoba == 999)
                    {
                        sqlQuery = "insert into roba values (default, '" + nazivTbox.Text + "', " + jedcijenaTbox.Text + " " + ", " + 0 + " " + ", '" + opisTbox.Text + "', " + idList[skladisteCbox.SelectedIndex] + " ); ";
                    }
                    else
                    {
                        sqlQuery = "update roba set naziv = '" + nazivTbox.Text + "', jedinicna_cijena = " + jedcijenaTbox.Text + ", opis = '" + opisTbox.Text + "', skladiste_idskladiste = " + idList[skladisteCbox.SelectedIndex] + " where idroba = " + idRoba + ";";
                    }
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Nije upisan iznos nije u pravilnom formatu");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Nije upisan iznos nije u pravilnom formatu");
            }
        }
    }
}
