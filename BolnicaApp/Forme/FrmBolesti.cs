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
    public partial class FrmBolesti : Form
    {
        public FrmBolesti()
        {
            InitializeComponent();
        }

        private void FrmBolesti_Load(object sender, EventArgs e)
        {
            OsvjeziDataGridView();
        }

        private void OsvjeziDataGridView()
        {
            dgvBolesti.DataSource = null;
            dgvBolesti.DataSource = Klase.Bolest.DohvatiSveBolesti();

            dgvBolesti.Columns[0].HeaderCell.Value = "ID";
            dgvBolesti.Columns[1].HeaderCell.Value = "Naziv bolesti";
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajBolest forma = new FrmDodajBolest();
            forma.ShowDialog();
            OsvjeziDataGridView();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBolesti.SelectedRows.Count > 0)
                {
                    Klase.Bolest bolest = dgvBolesti.SelectedRows[0].DataBoundItem as Klase.Bolest;
                    bolest.ObrisiBolest(bolest.Id);
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
            if (dgvBolesti.SelectedRows.Count > 0)
            {
                Klase.Bolest bolest = dgvBolesti.SelectedRows[0].DataBoundItem as Klase.Bolest;
                FrmUrediBolest forma = new FrmUrediBolest(bolest);
                forma.ShowDialog();
                OsvjeziDataGridView();
            }
            else
            {
                MessageBox.Show("Niste odabrali bolest!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
