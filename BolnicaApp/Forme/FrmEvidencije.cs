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
    public partial class FrmEvidencije : Form
    {
        #region Konstruktor i ostalo
        public FrmEvidencije()
        {
            InitializeComponent();
            OsvjeziDGVVrstePregleda();
            OsvjeziDGVSpecijalizacija();
            OsvjeziDGVTipZaposlenika();
        }
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region OsvjezavanjeDataGridViewa
        private void OsvjeziDGVVrstePregleda()
        {
            dgvVrstePregleda.DataSource = null;
            dgvVrstePregleda.DataSource = Klase.VrstaPregleda.DohvatiVrstePregleda();

            dgvVrstePregleda.Columns[0].HeaderCell.Value = "ID";
            dgvVrstePregleda.Columns[1].HeaderCell.Value = "Naziv pregleda";
            dgvVrstePregleda.Columns[2].HeaderCell.Value = "Trajanje";
        }

        private void OsvjeziDGVSpecijalizacija()
        {
            dgvSpecijalizacija.DataSource = null;
            dgvSpecijalizacija.DataSource = Klase.Specijalizacija.DohvatiSpecijalizacije();

            dgvSpecijalizacija.Columns[0].HeaderCell.Value = "ID";
            dgvSpecijalizacija.Columns[1].HeaderCell.Value = "Naziv specijalizacije";
        }

        private void OsvjeziDGVTipZaposlenika()
        {
            dgvTipZaposlenika.DataSource = null;
            dgvTipZaposlenika.DataSource = Klase.TipZaposlenika.DohvatiTipove();

            dgvTipZaposlenika.Columns[0].HeaderCell.Value = "ID";
            dgvTipZaposlenika.Columns[1].HeaderCell.Value = "Naziv tipa";
        }
        #endregion

        #region Brisanje
        private void btnObrisiPregled_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVrstePregleda.SelectedRows.Count > 0)
                {
                    Klase.VrstaPregleda vrsta = dgvVrstePregleda.SelectedRows[0].DataBoundItem as Klase.VrstaPregleda;
                    vrsta.ObrisiVrstuPregleda();
                    OsvjeziDGVVrstePregleda();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnObrisiSpecijalizaciju_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVrstePregleda.SelectedRows.Count > 0)
                {
                    Klase.Specijalizacija specijalizacija = dgvSpecijalizacija.SelectedRows[0].DataBoundItem as Klase.Specijalizacija;
                    specijalizacija.ObrisiSpecijalizaciju();
                    OsvjeziDGVSpecijalizacija();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisiTipZaposlenika_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipZaposlenika.SelectedRows.Count > 0)
                {
                    Klase.TipZaposlenika tip = dgvTipZaposlenika.SelectedRows[0].DataBoundItem as Klase.TipZaposlenika;
                    tip.ObrisiTipZaposlenika();
                    OsvjeziDGVTipZaposlenika();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Dodavanje
        private void btnDodajPregled_Click(object sender, EventArgs e)
        {
            if (txtNazivPregleda.Text != "" && int.TryParse(txtTrajanje.Text, out int trajanje))
            {
                string upit = "INSERT INTO vrsta_pregleda (naziv, trajanje) VALUES ('" + txtNazivPregleda.Text + "', " + trajanje + ");";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                OsvjeziDGVVrstePregleda();
            }
        }

        private void btnDodajSpecijalizaciju_Click(object sender, EventArgs e)
        {
            if (txtNazivSpecijalizacije.Text != "")
            {
                string upit = "INSERT INTO specijalizacija (naziv) VALUES ('" + txtNazivSpecijalizacije.Text + "');";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                OsvjeziDGVSpecijalizacija();
            }
        }

        private void btnDodajTipZaposlenika_Click(object sender, EventArgs e)
        {
            if (txtNazivTipa.Text != "")
            {
                string upit = "INSERT INTO tip_zaposlenika (naziv) VALUES ('" + txtNazivTipa.Text + "');";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                OsvjeziDGVTipZaposlenika();
            }

        }

        #endregion
    }
   
}
