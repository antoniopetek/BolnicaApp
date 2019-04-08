using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class PrikazPregleda
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string NazivPregleda { get; set; }
        public string Opis { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Zavrsetak { get; set; }

        public PrikazPregleda()
        {

        }

        public PrikazPregleda(NpgsqlDataReader dr) 
        {
            if (dr != null)
            {
                Ime = dr["ime"].ToString();
                Prezime = dr["prezime"].ToString();
                NazivPregleda = dr["naziv"].ToString();
                Opis = dr["opis"].ToString();
                Pocetak = DateTime.Parse(dr["pocetak"].ToString());
                Zavrsetak = DateTime.Parse(dr["zavrsetak"].ToString());
            }
        }

        public static List<PrikazPregleda> DohvatiPreglede(DateTime datum)
        {
            List<PrikazPregleda> lista = new List<PrikazPregleda>();
            string upit = "SELECT pa.ime, pa.prezime, vp.naziv, p.vrstapregleda, p.opis, k.pocetak, k.zavrsetak FROM vrsta_pregleda vp, pregled p, kalendar k, pacijent pa WHERE p.datumpregleda = '" + datum + "' AND p.doktor_id = '" + Klase.Zaposlenik.PrijavljeniZaposlenik.Id + "' AND p.id = k.pregled_id AND p.pacijent_id = pa.id AND p.vrstapregleda = vp.id";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                PrikazPregleda pp = new PrikazPregleda(dr);
                lista.Add(pp);
            }

            dr.Close();
            return lista;
        }
    }
}
