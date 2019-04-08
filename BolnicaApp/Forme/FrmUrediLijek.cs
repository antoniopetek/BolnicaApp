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
    public partial class FrmUrediLijek : Form
    {
        private Klase.Lijek lijek = null;

        public FrmUrediLijek()
        {
            InitializeComponent();
        }

        public FrmUrediLijek(Klase.Lijek proslijedeniLijek)
        {
            InitializeComponent();
            lijek = proslijedeniLijek;
        }

        private void FrmUrediLijek_Load(object sender, EventArgs e)
        {
            PopuniTextBoxeve();
        }

        private void PopuniTextBoxeve()
        {
            txtId.Text = lijek.Id.ToString();
            txtNaziv.Text = lijek.Naziv.ToString();
            txtOpis.Text = lijek.Opis.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "" && txtOpis.Text != "")
            {
                string upit = "UPDATE lijek SET naziv = '" + txtNaziv.Text + "', opis = '" + txtOpis.Text + "' WHERE id = " + lijek.Id + ";";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                Close();
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
