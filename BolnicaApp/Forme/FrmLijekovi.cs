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
    public partial class FrmLijekovi : Form
    {
        public FrmLijekovi()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajLijek forma = new FrmDodajLijek();
            forma.ShowDialog();
            OsvjeziDataGridView();
        }

        private void OsvjeziDataGridView()
        {
            dgvLijekovi.DataSource = null;
            dgvLijekovi.DataSource = Klase.Lijek.DohvatiSveLijekove();

            dgvLijekovi.Columns[0].HeaderCell.Value = "ID";
            dgvLijekovi.Columns[1].HeaderCell.Value = "Naziv lijeka";
            dgvLijekovi.Columns[2].HeaderCell.Value = "Opis lijeka";
        }

        private void FrmLijekovi_Load(object sender, EventArgs e)
        {
            OsvjeziDataGridView();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLijekovi.SelectedRows.Count > 0)
                {
                    Klase.Lijek lijek = dgvLijekovi.SelectedRows[0].DataBoundItem as Klase.Lijek;
                    lijek.ObrisiLijek();
                    OsvjeziDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvLijekovi.SelectedRows.Count > 0)
            {
                Klase.Lijek lijek = dgvLijekovi.SelectedRows[0].DataBoundItem as Klase.Lijek;
                FrmUrediLijek forma = new FrmUrediLijek(lijek);
                forma.ShowDialog();
                OsvjeziDataGridView();
            }
            else
            {
                MessageBox.Show("Niste odabrali lijek!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
