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
    public partial class FrmUrediZaposlenika : Form
    {
        private Klase.Zaposlenik zaposlenik = null;
        public FrmUrediZaposlenika()
        {
            InitializeComponent();
        }

        public FrmUrediZaposlenika(Klase.Zaposlenik dohvaceniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = dohvaceniZaposlenik;
            PuniComboBoxeve();
            PopuniTextBoxeve();
        }

        private void PopuniTextBoxeve()
        {
            txtID.Text = zaposlenik.Id.ToString();
            txtIme.Text = zaposlenik.Ime.ToString();
            txtPrezime.Text = zaposlenik.Prezime.ToString();
            txtEmail.Text = zaposlenik.Email.ToString();
            txtKontakt.Text = zaposlenik.Kontakt.ToString();
            txtDrzava.Text = zaposlenik.Drzava.ToString();
            txtGrad.Text = zaposlenik.Grad.ToString();
            txtUlica.Text = zaposlenik.Ulica.ToString();
            txtBroj.Text = zaposlenik.Broj.ToString();
            txtKorIme.Text = zaposlenik.KorisnickoIme.ToString();
            txtLozinka.Text = zaposlenik.Lozinka.ToString();
            cbTip.SelectedValue = zaposlenik.Tip_Zaposlenika_Id;
            cbBolnica.SelectedValue = zaposlenik.Bolnica_Id;
            cbSpecijalizacija.SelectedValue = zaposlenik.Specijalizacija_Id;
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtEmail.Text != "" && txtKontakt.Text != "" && txtDrzava.Text != "" && txtGrad.Text != "" && txtUlica.Text != "" && txtBroj.Text != "" && txtKorIme.Text != "" && txtLozinka.Text != "")
            {
                string upit = "UPDATE zaposlenik SET ime = '" + txtIme.Text + "', prezime = '" + txtPrezime.Text + "', email = '" + txtEmail.Text + "', kontakt = '" + txtKontakt.Text + "', drzava = '" + txtDrzava.Text + "', grad = '" + txtGrad.Text + "', ulica = '" + txtUlica.Text + "', broj = '" + txtBroj.Text + "', korisnickoime = '" + txtKorIme.Text + "', lozinka = '" + txtLozinka.Text + "', tip_zaposlenika_id = " + int.Parse(cbTip.SelectedValue.ToString()) + ", bolnica_id = " + int.Parse(cbBolnica.SelectedValue.ToString()) + ", specijalizacija_id = " + int.Parse(cbSpecijalizacija.SelectedValue.ToString()) + " WHERE id = " + zaposlenik.Id + ";";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                Close();
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
