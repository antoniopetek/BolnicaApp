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
    public partial class FrmUrediBolest : Form
    {
        private Klase.Bolest proslijedenaBolest = null;
        public FrmUrediBolest()
        {
            InitializeComponent();
        }

        public FrmUrediBolest(Klase.Bolest bolest)
        {
            InitializeComponent();
            proslijedenaBolest = bolest;
            PopuniTextBoxeve();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopuniTextBoxeve()
        {
            txtId.Text = proslijedenaBolest.Id.ToString();
            txtNaziv.Text = proslijedenaBolest.Naziv.ToString();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "")
            {
                string upit = "UPDATE bolest SET naziv = '" + txtNaziv.Text +"' WHERE id = " + proslijedenaBolest.Id + ";";
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
