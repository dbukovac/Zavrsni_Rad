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
    public partial class RacuniGraf : Form
    {
        string cs = "Server=localhost;Database=dbukovac;User=dbukovac;Password=63515379;Schema=NOVA";
        NuoDbConnection connection = null;
        DbDataReader rdr = null;
        IDictionary<string, int> dict = new Dictionary<string, int>();

        public RacuniGraf()
        {
            InitializeComponent();
            connection = new NuoDbConnection(cs);
        }

        private void GetPrimke()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select s.racun_idracun, r.naziv, s.kolicina from roba r join stavka_racuna s on s.roba_idroba = r.idroba order by 1;";
                NuoDbCommand command = new NuoDbCommand(sqlQuery, connection);
                grafDGV.Rows.Clear();
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string[] row = new string[] { rdr["racun_idracun"].ToString(), rdr["naziv"].ToString(), rdr["kolicina"].ToString() };
                    grafDGV.Rows.Add(row);
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

        private void FillList()
        {
            foreach (DataGridViewRow row in grafDGV.Rows)
            {
                if(dict.ContainsKey(row.Cells["Naziv_robe"].Value.ToString()))
                {
                    dict[row.Cells["Naziv_robe"].Value.ToString()] += int.Parse(row.Cells["Kolicina"].Value.ToString());
                }
                else
                {
                    dict.Add(row.Cells["Naziv_robe"].Value.ToString(), int.Parse(row.Cells["Kolicina"].Value.ToString()));
                }
            }
        }

        private void FillChart()
        {
            foreach (KeyValuePair<string, int> entry in dict)
            {
                chart1.Series["Roba"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        private void RacuniGraf_Load(object sender, EventArgs e)
        {
            GetPrimke();
            FillList();
            FillChart();
        }
    }
}
