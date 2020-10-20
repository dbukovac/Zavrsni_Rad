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

namespace GlavniIzbornik
{
    public partial class PrijavaForm : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;

        public PrijavaForm()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            string lozinka = "";
            int razina_prava = 999;
            int idzaposlenik = 999;
            try
            {
                connection.Open();
                string sqlQuery = "select * from zaposlenik join pozicija on zaposlenik.pozicija_idpozicija = pozicija.idpozicija where korisnicko_ime = '"+korimeTbox.Text+"'";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    lozinka = rdr["lozinka"].ToString();
                    razina_prava = (int)rdr["razina_prava"];
                    idzaposlenik = (int)rdr["idzaposlenik"];
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
            if(lozinka == LozinkaTbox.Text && LozinkaTbox.Text != "")
            {
                GlavnaForm forma = new GlavnaForm(razina_prava, idzaposlenik);
                this.Hide();
                forma.ShowDialog();
                this.Show();
            }
            else if(lozinka == "")
            {
                MessageBox.Show("Nepostojeće korisničko ime");
            }
            else
            {
                MessageBox.Show("Kriva lozinka");
            }
        }
    }
}
