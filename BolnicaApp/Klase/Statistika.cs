using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class Statistika
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }

        public Statistika(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Ime = dr["ime"].ToString();
                Prezime = dr["prezime"].ToString();
                Naziv = dr["naziv"].ToString();
                Kolicina = int.Parse(dr["count"].ToString());
            }
        }

        public static List<Statistika> DohvatiKolicine(int id)
        {
            List<Statistika> lista = new List<Statistika>();
            string upit = "SELECT z.ime, z.prezime, l.naziv, COUNT(*) FROM zaposlenik z, lijek l, recept r, recept_lijek rl WHERE r.id = rl.recept_id AND rl.lijek_id = l.id AND z.id = r.doktor_id AND z.id = +" + id + "GROUP BY 1,2,3;";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                Statistika s = new Statistika(dr);
                lista.Add(s);
            }

            dr.Close();
            return lista;
        }
    }
}
