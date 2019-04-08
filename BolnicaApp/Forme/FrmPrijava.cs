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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void FrmPrijava_Load_1(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text != "" && txtLozinka.Text != "")
            {
                Klase.Zaposlenik.PrijavljeniZaposlenik = Klase.Zaposlenik.DohvatiZaposlenika(txtKorisnickoIme.Text, txtLozinka.Text);
                if (Klase.Zaposlenik.PrijavljeniZaposlenik != null)
                {
                    FrmGlavniIzbornik forma = new FrmGlavniIzbornik();
                    forma.ShowDialog();
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                }
                else
                {
                    MessageBox.Show("Unijeli ste krive podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli potrebne podatake za prijavu!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrikaziLozinku.Checked == true)
            {
                txtLozinka.PasswordChar = '\0';
            }
            else
            {
                txtLozinka.PasswordChar = '*';
            }
        }
    }
}
