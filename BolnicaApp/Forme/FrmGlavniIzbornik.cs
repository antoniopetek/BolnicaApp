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
    public partial class FrmGlavniIzbornik : Form
    {
        public FrmGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void FrmGlavniIzbornik_Load(object sender, EventArgs e)
        {
            PodaciOPrijavljenomDoktoru();
            ProvjeraDopustenja();
        }

        private void PodaciOPrijavljenomDoktoru()
        {
            Klase.Specijalizacija specijalizacija = Klase.Specijalizacija.DohvatiSpecijalizaciju(Klase.Zaposlenik.PrijavljeniZaposlenik.Specijalizacija_Id);
            lblIme.Text = Klase.Zaposlenik.PrijavljeniZaposlenik.Ime.ToString();
            lblPrezime.Text = Klase.Zaposlenik.PrijavljeniZaposlenik.Prezime.ToString();
            lblSpecijalizacija.Text = specijalizacija.Naziv.ToString();
            lblAdresa.Text = Klase.Zaposlenik.PrijavljeniZaposlenik.Ulica + " " + Klase.Zaposlenik.PrijavljeniZaposlenik.Broj + ", " + Klase.Zaposlenik.PrijavljeniZaposlenik.Grad;
            lblEmail.Text = Klase.Zaposlenik.PrijavljeniZaposlenik.Email.ToString();
            lblKontakt.Text = Klase.Zaposlenik.PrijavljeniZaposlenik.Kontakt.ToString();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
            MessageBox.Show("Uspješno ste se odjavili.", "Odjava", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void ProvjeraDopustenja()
        {
            int tipZaposlenika = Klase.Zaposlenik.PrijavljeniZaposlenik.Tip_Zaposlenika_Id;
            
            if (tipZaposlenika != 1)
            {
                btnZaposlenici.Enabled = false;
            }
        }

        private void btnPregledi_Click(object sender, EventArgs e)
        {
            FrmPregledi forma = new FrmPregledi();
            forma.ShowDialog();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmZaposlenici forma = new FrmZaposlenici();
            forma.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            FrmStatistika forma = new FrmStatistika();
            forma.ShowDialog();
        }

        private void btnBolesti_Click(object sender, EventArgs e)
        {
            FrmBolesti forma = new FrmBolesti();
            forma.ShowDialog();
        }

        private void btnLijekovi_Click(object sender, EventArgs e)
        {
            FrmLijekovi forma = new FrmLijekovi();
            forma.ShowDialog();
        }

        private void btnEvidencije_Click(object sender, EventArgs e)
        {
            FrmEvidencije forma = new FrmEvidencije();
            forma.ShowDialog();
        }

        private void btnRecepti_Click(object sender, EventArgs e)
        {
            FrmPregledRecepata forma = new FrmPregledRecepata();
            forma.ShowDialog();
        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            FrmPacijenti forma = new FrmPacijenti();
            forma.ShowDialog();
        }

        private void btnKarton_Click(object sender, EventArgs e)
        {
            FrmZdravstveniKarton forma = new FrmZdravstveniKarton();
            forma.ShowDialog();
        }
    }
}
