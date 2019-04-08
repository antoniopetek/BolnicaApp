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
    public partial class FrmZaposlenici : Form
    {
        public FrmZaposlenici()
        {
            InitializeComponent();
        }

        private void FrmZaposlenici_Load(object sender, EventArgs e)
        {
            OsvjeziDataGridView();
        }

        private void OsvjeziDataGridView()
        {
            List<Klase.Zaposlenik> zaposlenici = Klase.Zaposlenik.DohvatiSveZaposlenike();
            dgvZaposlenici.DataSource = null;
            dgvZaposlenici.DataSource = zaposlenici;

            dgvZaposlenici.Columns[11].Visible = false;
            dgvZaposlenici.Columns[12].Visible = false;
            dgvZaposlenici.Columns[13].Visible = false;

            dgvZaposlenici.Columns[0].HeaderCell.Value = "ID";
            dgvZaposlenici.Columns[5].HeaderCell.Value = "Država";
            dgvZaposlenici.Columns[9].HeaderCell.Value = "Korisničko ime";
            dgvZaposlenici.Columns[14].HeaderCell.Value = "Puno ime";
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajZaposlenika forma = new FrmDodajZaposlenika();
            forma.ShowDialog();
            OsvjeziDataGridView();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvZaposlenici.SelectedRows.Count > 0)
                {
                    Klase.Zaposlenik zaposlenik = dgvZaposlenici.SelectedRows[0].DataBoundItem as Klase.Zaposlenik;
                    zaposlenik.ObrisiZaposlenika(zaposlenik.Id);
                    OsvjeziDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                Klase.Zaposlenik odabraniZaposlenik = dgvZaposlenici.SelectedRows[0].DataBoundItem as Klase.Zaposlenik;
                FrmUrediZaposlenika forma = new FrmUrediZaposlenika(odabraniZaposlenik);
                forma.ShowDialog();
                OsvjeziDataGridView();
            }
        }
    }
}
