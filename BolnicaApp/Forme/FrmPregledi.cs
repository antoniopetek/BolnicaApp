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
    public partial class FrmPregledi : Form
    {
        public FrmPregledi()
        {
            InitializeComponent();
        }

        private void OsvjeziDataGridView()
        {
            dgvPregledi.DataSource = null;
            dgvPregledi.DataSource = Klase.PrikazPregleda.DohvatiPreglede(dtpDatum.Value);

            dgvPregledi.Columns[2].HeaderCell.Value = "Naziv pregleda";
            dgvPregledi.Columns[4].HeaderCell.Value = "Početak";
            dgvPregledi.Columns[5].HeaderCell.Value = "Završetak";
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            OsvjeziDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajPregled_Click(object sender, EventArgs e)
        {
            FrmRezervacijaPregleda forma = new FrmRezervacijaPregleda();
            forma.ShowDialog();
            OsvjeziDataGridView();
        }

        private void FrmPregledi_Load(object sender, EventArgs e)
        {
            OsvjeziDataGridView();
        }
    }
}
