using Npgsql;
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
    public partial class FrmRecepti : Form
    {
        private List<Klase.Lijek> sviLijekovi = new List<Klase.Lijek>();
        private List<Klase.Lijek> odabraniLijekovi = new List<Klase.Lijek>();

        public FrmRecepti()
        {
            InitializeComponent();
        }

        private void FrmRecepti_Load(object sender, EventArgs e)
        {
            PopuniComboBox();
            sviLijekovi = Klase.Lijek.DohvatiSveLijekove();
            foreach (Klase.Lijek lijek in sviLijekovi)
            {
                lbPopisLijekova.Items.Add(lijek);
            }
        }

        private void PopuniComboBox()
        {
            cbPacijenti.DataSource = Klase.Pacijent.DohvatiPacijente();
            cbPacijenti.ValueMember = "id";
            cbPacijenti.DisplayMember = "PunoIme";
        }

        private void PopuniListBox()
        {
            lbPopisLijekova.Items.Clear();
            foreach (Klase.Lijek lijek in sviLijekovi)
            {
                lbPopisLijekova.Items.Add(lijek);
            }
        }
        private void PopuniDrugiListBox()
        {
            lbLijekoviRecept.Items.Clear();
            foreach (Klase.Lijek lijek in odabraniLijekovi)
            {
                lbLijekoviRecept.Items.Add(lijek);
            }
        }

        private void btnDodajJedan_Click(object sender, EventArgs e)
        {
            if (lbPopisLijekova.SelectedItem != null)
            {
                Klase.Lijek odabraniLijek = (Klase.Lijek)lbPopisLijekova.SelectedItem;
                odabraniLijekovi.Add(odabraniLijek);
                sviLijekovi.Remove(odabraniLijek);
                PopuniListBox();
                PopuniDrugiListBox();
            }
            else
            {
                MessageBox.Show("Niste odabrali lijek iz popisa lijekova.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVratiJedan_Click(object sender, EventArgs e)
        {
            if (lbLijekoviRecept.SelectedItem != null)
            {
                Klase.Lijek lijekVracanje = (Klase.Lijek)lbLijekoviRecept.SelectedItem;
                odabraniLijekovi.Remove(lijekVracanje);
                sviLijekovi.Add(lijekVracanje);
                PopuniListBox();
                PopuniDrugiListBox();
            }
            else
            {
                MessageBox.Show("Niste odabrali lijek koji želite vratiti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajSve_Click(object sender, EventArgs e)
        {
            int brojac = lbPopisLijekova.Items.Count;
            for (int i = 0; i < brojac; i++)
            {
                Klase.Lijek lijek = (Klase.Lijek)lbPopisLijekova.Items[0];
                odabraniLijekovi.Add(lijek);
                sviLijekovi.Remove(lijek);
                PopuniListBox();
                PopuniDrugiListBox();
            }
        }

        private void btnVratiSve_Click(object sender, EventArgs e)
        {
            int brojac = lbLijekoviRecept.Items.Count;
            for (int i = 0; i < brojac; i++)
            {
                Klase.Lijek lijek = (Klase.Lijek)lbLijekoviRecept.Items[0];
                sviLijekovi.Add(lijek);
                odabraniLijekovi.Remove(lijek);
                PopuniListBox();
                PopuniDrugiListBox();
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzdajRecept_Click(object sender, EventArgs e)
        {
            try
            {
                if (odabraniLijekovi.Count != 0)
                {
                    string upit = "INSERT INTO recept (doktor_id, pacijent_id, datumizdavanja) VALUES (" + Klase.Zaposlenik.PrijavljeniZaposlenik.Id + ", " + cbPacijenti.SelectedValue + ", '" + dtpDatumIzdavanja.Value + "');";
                    Klase.Baza.Instanca.IzvrsiUpit(upit);

                    Klase.Recept recept = Klase.Recept.DohvatiRecept();

                    foreach (Klase.Lijek lijek in odabraniLijekovi)
                    {
                        string upit2 = "INSERT INTO recept_lijek (recept_id, lijek_id) VALUES (" + recept.Id + ", " + lijek.Id + ");";
                        Klase.Baza.Instanca.IzvrsiUpit(upit2);
                    }

                    MessageBox.Show("Recept uspješno izdan!", "Recept izdan", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Niste odabrali nijedan lijek.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
