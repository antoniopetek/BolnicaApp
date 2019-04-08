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
    public partial class FrmDodajZaposlenika : Form
    {
        public FrmDodajZaposlenika()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtEmail.Text != "" && txtKontakt.Text != "" && txtDrzava.Text != "" && txtGrad.Text != "" && txtUlica.Text != "" && txtBroj.Text != "" && txtKorIme.Text != "" && txtLozinka.Text != "")
            {
                string upit = "INSERT INTO zaposlenik (ime, prezime, email, kontakt, drzava, grad, ulica, broj, korisnickoime, lozinka, tip_zaposlenika_id, bolnica_id, specijalizacija_id) VALUES ('" + txtIme.Text + "', '" + txtPrezime.Text + "', '" + txtEmail.Text + "', '" + txtKontakt.Text + "', '" + txtDrzava.Text + "', '" + txtGrad.Text + "', '" + txtUlica.Text + "', '" + txtBroj.Text + "', '" + txtKorIme.Text + "', '" + txtLozinka.Text + "', " + int.Parse(cbTip.SelectedValue.ToString()) + ", " + int.Parse(cbBolnica.SelectedValue.ToString()) + ", " + int.Parse(cbSpecijalizacija.SelectedValue.ToString()) + ");";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                MessageBox.Show("Zaposlenik uspješno dodan.", "Dodan zaposlenik", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDodajZaposlenika_Load(object sender, EventArgs e)
        {
            PuniComboBoxeve();            
        }

        private void PuniComboBoxeve()
        {
            cbSpecijalizacija.DataSource = Klase.Specijalizacija.DohvatiSpecijalizacije();
            cbSpecijalizacija.ValueMember = "id";
            cbSpecijalizacija.DisplayMember = "naziv";

            cbBolnica.DataSource = Klase.Bolnica.DohvatiBolnice();
            cbBolnica.ValueMember = "id";
            cbBolnica.DisplayMember = "naziv";

            cbTip.DataSource = Klase.TipZaposlenika.DohvatiTipove();
            cbTip.ValueMember = "id";
            cbTip.DisplayMember = "naziv";
        }
    }
}
