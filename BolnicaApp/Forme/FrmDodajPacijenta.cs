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
    public partial class FrmDodajPacijenta : Form
    {
        public FrmDodajPacijenta()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtEmail.Text != "" && txtKontakt.Text != "" && txtDrzava.Text != "" && txtGrad.Text != "" && txtUlica.Text != "" && txtBroj.Text != "")
            {
                string upit = "INSERT INTO pacijent (ime, prezime, datumrodenja, drzava, grad, ulica, broj, email, kontakt) VALUES ('" + txtIme.Text + "', '" + txtPrezime.Text + "', '" + dtpDatum.Value + "', '" + txtDrzava.Text + "', '" + txtGrad.Text + "', '" + txtUlica.Text + "', '" + txtBroj.Text + "', '" + txtEmail.Text + "', '" + txtKontakt.Text + "');";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                MessageBox.Show("Pacijent uspješno dodan.", "Dodan pacijent", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
