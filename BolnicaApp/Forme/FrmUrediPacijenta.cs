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
    public partial class FrmUrediPacijenta : Form
    {
        private static Klase.Pacijent pacijent = null;
        public FrmUrediPacijenta()
        {
            InitializeComponent();
        }

        public FrmUrediPacijenta(Klase.Pacijent proslijedeniPacijent)
        {
            InitializeComponent();
            pacijent = proslijedeniPacijent;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUrediPacijenta_Load(object sender, EventArgs e)
        {
            PuniTextBoxeve();
        }

        private void PuniTextBoxeve()
        {
            txtID.Text = pacijent.Id.ToString();
            txtIme.Text = pacijent.Ime.ToString();
            txtPrezime.Text = pacijent.Prezime.ToString();
            dtpDatum.Value = pacijent.DatumRodenja;
            txtDrzava.Text = pacijent.Drzava.ToString();
            txtGrad.Text = pacijent.Grad.ToString();
            txtUlica.Text = pacijent.Ulica.ToString();
            txtBroj.Text = pacijent.Broj.ToString();
            txtEmail.Text = pacijent.Email.ToString();
            txtKontakt.Text = pacijent.Kontakt.ToString();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtEmail.Text != "" && txtKontakt.Text != "" && txtDrzava.Text != "" && txtGrad.Text != "" && txtUlica.Text != "" && txtBroj.Text != "")
            {
                string upit = "UPDATE pacijent SET ime = '" + txtIme.Text + "', prezime = '" + txtPrezime.Text + "', email = '" + txtEmail.Text + "', kontakt = '" + txtKontakt.Text + "', drzava = '" + txtDrzava.Text + "', grad = '" + txtGrad.Text + "', ulica = '" + txtUlica.Text + "', broj = '" + txtBroj.Text + "', datumrodenja = '" + dtpDatum.Value + "' WHERE id = " + pacijent.Id + ";";
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
