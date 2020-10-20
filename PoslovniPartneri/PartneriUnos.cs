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

namespace PoslovniPartneri
{
    public partial class PartneriUnos : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        List<int> idList;
        int idPartner;

        public PartneriUnos()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idPartner = 0;
        }

        public PartneriUnos(int id)
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
            idPartner = id;
        }

        private void FillComboBox()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from tip_partnera";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                tipCbox.Items.Clear();
                rdr = command.ExecuteReader();
                tipCbox.DisplayMember = "Text";
                tipCbox.ValueMember = "Value";
                idList = new List<int>();
                while (rdr.Read())
                {
                    tipCbox.Items.Add(new { Text = rdr["naziv"].ToString(), Value = rdr["idtip_partnera"].ToString() });
                    idList.Add(int.Parse(rdr["idtip_partnera"].ToString()));
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
                string sqlQuery = "select * from poslovni_partner join tip_partnera on poslovni_partner.tip_partnera_idtip_partnera = tip_partnera.idtip_partnera where idposlovni_partner = "+idPartner+";";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    nazivTbox.Text = rdr["naziv"].ToString();
                    oibTbox.Text = rdr["oib"].ToString();
                    telbrojTbox.Text = rdr["telefonski_broj"].ToString();
                    adresaTbox.Text = rdr["adresa"].ToString();
                    brojracunaTbox.Text = rdr["broj_racuna"].ToString();
                    tipCbox.Text = rdr[8].ToString();
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

        private void spremiButton_Click(object sender, EventArgs e)
        {
            double OIB;
            int telBroj;
            if (double.TryParse(oibTbox.Text, out OIB) && oibTbox.Text.Length == 11 && int.TryParse(telbrojTbox.Text, out telBroj) && tipCbox.SelectedIndex >= 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    if (idPartner == 0)
                    {
                        sqlQuery = "insert into poslovni_partner values (default, '" + nazivTbox.Text + "', '" + OIB + "' " + ", '" + telBroj + "' " + ", '" + adresaTbox.Text + "' " + ", '" + brojracunaTbox.Text + "', " + idList[tipCbox.SelectedIndex] + " ); ";
                    }
                    else
                    {
                        sqlQuery = "update poslovni_partner set naziv = '" + nazivTbox.Text + "', oib = '" + oibTbox.Text + "', telefonski_broj = '" + telBroj + "', adresa = '" + adresaTbox.Text + "', broj_racuna = '" + brojracunaTbox.Text + "', tip_partnera_idtip_partnera = " + idList[tipCbox.SelectedIndex] + " where idposlovni_partner = " + idPartner + ";";
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
            else
            {
                MessageBox.Show("Krivo upisani OIB");
            }
        }

        private void PartneriUnos_Load(object sender, EventArgs e)
        {
            FillComboBox();
            if(idPartner != 999)
            {
                FillBoxes();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
