using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    public class Lijek
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public Lijek()
        {

        }

        public Lijek(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();
                Opis = dr["opis"].ToString();
            }
        }
        public static List<Lijek> DohvatiSveLijekove()
        {
            List<Lijek> lijekovi = new List<Lijek>();
            string upit = "SELECT * FROM lijek;";

            NpgsqlDataReader dr = Klase.Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                Lijek l = new Lijek(dr);
                lijekovi.Add(l);
            }

            dr.Close();
            return lijekovi;
        }
        public int ObrisiLijek()
        {
            string upit = "DELETE FROM lijek WHERE id = " + Id;
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }
        public override string ToString()
        {
            return Naziv;
        }


    }
}
