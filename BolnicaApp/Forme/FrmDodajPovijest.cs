using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolnicaApp.Forme
{
    public partial class FrmDodajPovijest : Form
    {
        public FrmDodajPovijest()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDodajPovijest_Load(object sender, EventArgs e)
        {
            PuniComboBox();
            PuniListBox();
        }

        private void PuniComboBox()
        {
            cbPacijenti.DataSource = null;
            cbPacijenti.DataSource = Klase.Pacijent.DohvatiPacijente();

            cbPacijenti.DisplayMember = "PunoIme";
            cbPacijenti.ValueMember = "Id";
        }

        private void PuniListBox()
        {
            List<Klase.Bolest> bolesti = Klase.Bolest.DohvatiSveBolesti();

            foreach (Klase.Bolest bolest in bolesti)
            {
                lbPopisBolesti.Items.Add(bolest);
            }
        }

        private void btnDodajBolestPacijentu_Click(object sender, EventArgs e)
        {
            if (lbPopisBolesti.SelectedItem != null && cbPacijenti.SelectedItem != null && txtOpisStanja.Text != "")
            {
                Klase.Bolest bolest = lbPopisBolesti.SelectedItem as Klase.Bolest;
                string upit = "INSERT INTO povijest_bolesti (pacijent_id, bolest_id, opisstanja) VALUES (" + cbPacijenti.SelectedValue + ", " + bolest.Id + ", '" + txtOpisStanja.Text + "');";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                MessageBox.Show("Ažuriran zdravstveni karton pacijenta!", "Ažurirano", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                MessageBox.Show("Niste odabrali pacijenta, bolest ili niste upisali stanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
