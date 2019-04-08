using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class TipZaposlenika
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public TipZaposlenika()
        {

        }

        public TipZaposlenika(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();
            }
        }

        public static List<TipZaposlenika> DohvatiTipove()
        {
            List<TipZaposlenika> tipovi = new List<TipZaposlenika>();
            string upit = "SELECT * FROM tip_zaposlenika";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                TipZaposlenika s = new TipZaposlenika(dr);
                tipovi.Add(s);
            }

            dr.Close();
            return tipovi;
        }

        public override string ToString()
        {
            return Naziv;
        }

        public int ObrisiTipZaposlenika()
        {
            string upit = "DELETE FROM tip_zaposlenika WHERE id = " + Id;
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }
    }
}
