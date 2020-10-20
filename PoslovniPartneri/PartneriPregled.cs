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
    public partial class PartneriPregled : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;

        public PartneriPregled()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
        }

        private void PartneriPregled_Load(object sender, EventArgs e)
        {
            GetPartneri();
        }

        private void GetPartneri()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select * from poslovni_partner join tip_partnera on poslovni_partner.tip_partnera_idtip_partnera = tip_partnera.idtip_partnera";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                partneriDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["idposlovni_partner"].ToString(), rdr["naziv"].ToString(), rdr["oib"].ToString(), rdr["telefonski_broj"].ToString(), rdr["adresa"].ToString(), rdr["broj_racuna"].ToString(), rdr[8].ToString() };
                    partneriDGV.Rows.Add(row);
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

        private void noviPartnerButton_Click(object sender, EventArgs e)
        {
            PartneriUnos forma = new PartneriUnos();
            forma.ShowDialog();
            GetPartneri();
        }

        private void izmjeniPartneraButton_Click(object sender, EventArgs e)
        {
            if (partneriDGV.SelectedRows.Count > 0)
            {
                PartneriUnos forma = new PartneriUnos(int.Parse(partneriDGV.CurrentRow.Cells[0].Value.ToString()));
                forma.ShowDialog();
                GetPartneri();
            }
            else
            {
                MessageBox.Show("Nije odabran partner");
            }
        }

        private void obrisiPartneraButton_Click(object sender, EventArgs e)
        {
            if (partneriDGV.SelectedRows.Count > 0)
            {
                try
                {
                    connection.Open();
                    string sqlQuery;
                    sqlQuery = "delete from poslovni_partner where idposlovni_partner = " + int.Parse(partneriDGV.CurrentRow.Cells[0].Value.ToString()) + "";
                    NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspješno izvršeno");
                }
                catch (NuoDbSqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    MessageBox.Show("Poslovni partner se ne može brisati dok se navodi na računima ili primkama");
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                    GetPartneri();

                }
            }
            else
            {
                MessageBox.Show("Nije odabran partner");
            }
        }
    }
}
