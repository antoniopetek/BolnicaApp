using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pretrazivanje;

namespace BolnicaApp.Forme
{
    public partial class FrmZdravstveniKarton : Form
    {
        private Pretraga pretraga = new Pretraga();
        public FrmZdravstveniKarton()
        {
            InitializeComponent();
        }

        private void FrmZdravstveniKarton_Load(object sender, EventArgs e)
        {
            OsvjeziDGVPacijenti();
        }

        private void OsvjeziDGVPacijenti()
        {
            dgvPacijenti.DataSource = null;
            dgvPacijenti.DataSource = Klase.Pacijent.DohvatiPacijente();

            dgvPacijenti.Columns[4].Visible = false;
            dgvPacijenti.Columns[5].Visible = false;
            dgvPacijenti.Columns[6].Visible = false;
            dgvPacijenti.Columns[7].Visible = false;
            dgvPacijenti.Columns[10].Visible = false;

            dgvPacijenti.Columns[0].HeaderCell.Value = "ID";
            dgvPacijenti.Columns[3].HeaderCell.Value = "Datum rođenja";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            pretraga.Pretrazi(dgvPacijenti, txtPretraga.Text.ToLower(), 10);
        }

        private void dgvPacijenti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPacijenti.SelectedRows.Count > 0)
            {
                int pacijentId = int.Parse(dgvPacijenti.CurrentRow.Cells[0].Value.ToString());
                dgvPovijest.DataSource = null;
                dgvPovijest.DataSource = Klase.PacijentBolest.DohvatiPovijestBolesti(pacijentId);

                dgvPovijest.Columns[1].HeaderCell.Value = "Naziv bolesti";
                dgvPovijest.Columns[2].HeaderCell.Value = "Opis stanja";
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajPovijest forma = new FrmDodajPovijest();
            forma.ShowDialog();
            OsvjeziDGVPacijenti();
        }
    }
}
