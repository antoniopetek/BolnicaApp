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
    public partial class FrmPregledRecepata : Form
    {
        public FrmPregledRecepata()
        {
            InitializeComponent();
        }

        private void FrmPregledRecepata_Load(object sender, EventArgs e)
        {
            OsvjeziDGVRecepti();
        }

        private void OsvjeziDGVRecepti()
        {
            dgvRecepti.DataSource = null;
            dgvRecepti.DataSource = Klase.PregledRecepata.DohvatiRecepte();
        }

        private void dgvRecepti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count > 0)
            {
                int receptId = int.Parse(dgvRecepti.CurrentRow.Cells[0].Value.ToString());
                dgvLijekovi.DataSource = null;
                dgvLijekovi.DataSource = Klase.ReceptLijek.DohvatiLijekoveNaReceptu(receptId); ;

                dgvLijekovi.Columns[0].HeaderCell.Value = "ID recepta";
                dgvLijekovi.Columns[1].HeaderCell.Value = "Naziv lijeka";
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmRecepti forma = new FrmRecepti();
            forma.ShowDialog();
            OsvjeziDGVRecepti();
        }
    }
}
