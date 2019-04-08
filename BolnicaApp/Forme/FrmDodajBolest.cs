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
    public partial class FrmDodajBolest : Form
    {
        public FrmDodajBolest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "")
            {
                string upit = "INSERT INTO bolest (naziv) VALUES ('" + txtNaziv.Text + "');";
                Klase.Baza.Instanca.IzvrsiUpit(upit);
                Close();
            }
        }
    }
}
