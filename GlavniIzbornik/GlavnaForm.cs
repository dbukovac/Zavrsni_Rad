using PoslovniPartneri;
using Primke;
using Racuni;
using Roba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaposlenici;

namespace GlavniIzbornik
{
    delegate void ShowFormDelegate(Form form, Form parentForm);

    public partial class GlavnaForm : Form
    {
        int razina_prava;
        int idzaposlenik;
        public GlavnaForm(int raz, int zap)
        {
            InitializeComponent();
            razina_prava = raz;
            idzaposlenik = zap;
        }

        private void ShowForm(Form form, Form parentForm)
        {
            if (form.InvokeRequired)
            {
                ShowFormDelegate showFormDelegate = new ShowFormDelegate(ShowForm);
                form.BeginInvoke(showFormDelegate, form, parentForm);
            }
            else
            {
                form.MdiParent = parentForm;
                parentForm.Size = new Size(form.Width + 15, form.Height + 25);
                form.WindowState = FormWindowState.Maximized;
                form.Show();

            }
        }

        private void poslovniPartneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartneriPregled partneriForm = new PartneriPregled();
            ShowForm(partneriForm, this);
        }

        private void robaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RobaPregled robaForm = new RobaPregled();
            ShowForm(robaForm, this);
        }

        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkladistePregled skladisteForm = new SkladistePregled();
            ShowForm(skladisteForm, this);
        }

        private void zaposleniciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZaposleniciPregled zaposleniciForm = new ZaposleniciPregled();
            ShowForm(zaposleniciForm, this);
        }

        private void pozicijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PozicijaPregled pozicijaForm = new PozicijaPregled();
            ShowForm(pozicijaForm, this);
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            if(razina_prava != 1)
            {
                zaposleniciToolStripMenuItem.Visible = false;
            }
        }

        private void pregledRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RacuniPregled racuniForm = new RacuniPregled(idzaposlenik);
            ShowForm(racuniForm, this);
        }

        private void pregledPrimkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimkePregled primkeForm = new PrimkePregled(idzaposlenik);
            ShowForm(primkeForm, this);
        }

        private void statistikaRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RacuniGraf primkeForm = new RacuniGraf();
            ShowForm(primkeForm, this);
        }

        private void primkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimkePregled primkeForm = new PrimkePregled(idzaposlenik);
            ShowForm(primkeForm, this);
        }
    }
}