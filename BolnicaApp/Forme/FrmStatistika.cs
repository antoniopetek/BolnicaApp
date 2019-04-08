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
    public partial class FrmStatistika : Form
    {
        public FrmStatistika()
        {
            InitializeComponent();
        }

        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            PopuniComboBox();
        }

        private void PopuniComboBox()
        {
            cbZaposlenik.DataSource = null;
            cbZaposlenik.DataSource = Klase.Zaposlenik.DohvatiSveZaposlenike();

            cbZaposlenik.ValueMember = "id";
            cbZaposlenik.DisplayMember = "PunoIme";
        }

        private void cbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {   
            chGraf.Series["Kolicina"].Points.Clear();
            CrtajGraf();
        }

        private void CrtajGraf()
        {
            Klase.Zaposlenik zaposlenik = (Klase.Zaposlenik)cbZaposlenik.SelectedItem;
            List<Klase.Statistika> statistika = Klase.Statistika.DohvatiKolicine(int.Parse(zaposlenik.Id.ToString()));
            chGraf.DataSource = statistika;
            chGraf.Series["Kolicina"].XValueMember = "Naziv";
            chGraf.Series["Kolicina"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chGraf.Series["Kolicina"].YValueMembers = "Kolicina";
            chGraf.Series["Kolicina"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
