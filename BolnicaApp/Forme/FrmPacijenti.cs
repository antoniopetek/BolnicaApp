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
    public partial class FrmPacijenti : Form
    {
        public FrmPacijenti()
        {
            InitializeComponent();
        }

        private void FrmPacijenti_Load(object sender, EventArgs e)
        {
            OsvjeziDataGridView();
        }

        private void OsvjeziDataGridView()
        {
            dgvPacijenti.DataSource = null;
            dgvPacijenti.DataSource = Klase.Pacijent.DohvatiPacijente();

            dgvPacijenti.Columns[0].HeaderCell.Value = "ID";
            dgvPacijenti.Columns[3].HeaderCell.Value = "Datum rođenja";
            dgvPacijenti.Columns[4].HeaderCell.Value = "Država";
            dgvPacijenti.Columns[10].HeaderCell.Value = "Puno ime";
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacijenti.SelectedRows.Count > 0)
                {
                    Klase.Pacijent pacijent = dgvPacijenti.SelectedRows[0].DataBoundItem as Klase.Pacijent;
                    pacijent.ObrisiPacijenta();
                    OsvjeziDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajPacijenta forma = new FrmDodajPacijenta();
            forma.ShowDialog();
            OsvjeziDataGridView();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvPacijenti.SelectedRows.Count > 0)
            {
                Klase.Pacijent odabraniPacijent = dgvPacijenti.SelectedRows[0].DataBoundItem as Klase.Pacijent;
                FrmUrediPacijenta forma = new FrmUrediPacijenta(odabraniPacijent);
                forma.ShowDialog();
                OsvjeziDataGridView();
            }
        }
    }
}
