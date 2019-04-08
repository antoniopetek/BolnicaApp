using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class VrstaPregleda
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }

        public VrstaPregleda()
        {

        }

        public VrstaPregleda(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();
                Trajanje = int.Parse(dr["trajanje"].ToString());
            }
        }

        public static List<VrstaPregleda> DohvatiVrstePregleda()
        {
            List<VrstaPregleda> vrste = new List<VrstaPregleda>();
            string upit = "SELECT * FROM vrsta_pregleda";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                VrstaPregleda s = new VrstaPregleda(dr);
                vrste.Add(s);
            }

            dr.Close();
            return vrste;
        }

        public int ObrisiVrstuPregleda()
        {
            string upit = "DELETE FROM vrsta_pregleda WHERE id = " + Id;
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }
    }
}
