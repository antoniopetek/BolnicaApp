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
    public partial class FrmRezervacijaPregleda : Form
    {
        public FrmRezervacijaPregleda()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PuniComboBoxPacijenti()
        {
            cbPacijenti.DataSource = null;
            cbPacijenti.DataSource = Klase.Pacijent.DohvatiPacijente();

            cbPacijenti.ValueMember = "id";
            cbPacijenti.DisplayMember = "PunoIme";
        }
        private void PuniComboBoxVrstePregleda()
        {
            cbVrstaPregleda.DataSource = null;
            cbVrstaPregleda.DataSource = Klase.VrstaPregleda.DohvatiVrstePregleda();

            cbVrstaPregleda.ValueMember = "id";
            cbVrstaPregleda.DisplayMember = "naziv";
        }

        private void FrmRezervacijaPregleda_Load(object sender, EventArgs e)
        {
            PuniComboBoxPacijenti();
            PuniComboBoxVrstePregleda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPacijenti.SelectedItem != null && cbVrstaPregleda.SelectedItem != null && txtOpis.Text != "")
                {
                    Klase.Pacijent pacijent = cbPacijenti.SelectedItem as Klase.Pacijent;
                    Klase.VrstaPregleda vrsta = cbVrstaPregleda.SelectedItem as Klase.VrstaPregleda;

                    string upit = "INSERT INTO pregled (doktor_id, pacijent_id, vrstapregleda, datumpregleda, opis) VALUES (" + Klase.Zaposlenik.PrijavljeniZaposlenik.Id + ", " + pacijent.Id + ", " + vrsta.Id + ", '" + dtpDatum.Value + "', '" + txtOpis.Text + "');";
                    Klase.Baza.Instanca.IzvrsiUpit(upit);
                    MessageBox.Show("Pregled uspješno rezerviran.", "Rezervirano", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Niste unijeli sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
