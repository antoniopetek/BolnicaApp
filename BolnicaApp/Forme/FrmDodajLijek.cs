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
    public partial class FrmDodajLijek : Form
    {
        public FrmDodajLijek()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "" && txtOpis.Text != "")
            {
                string upit = "INSERT INTO lijek (naziv, opis) VALUES ('" + txtNaziv.Text + "', '" + txtOpis.Text + "');";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                Close();
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
