using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class Specijalizacija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public Specijalizacija()
        {

        }

        public Specijalizacija(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();
            }
        }

        public static Specijalizacija DohvatiSpecijalizaciju(int id)
        {
            Specijalizacija specijalizacija = null;
            string sqlUpit = "SELECT * FROM specijalizacija WHERE id = '" + id + "';";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                specijalizacija = new Specijalizacija(dr);
            }
            dr.Close();
            return specijalizacija;
        }

        public static List<Specijalizacija> DohvatiSpecijalizacije()
        {
            List<Specijalizacija> specijalizacije = new List<Specijalizacija>();
            string upit = "SELECT * FROM specijalizacija";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                Specijalizacija s = new Specijalizacija(dr);
                specijalizacije.Add(s);
            }

            dr.Close();
            return specijalizacije;
        }

        public override string ToString()
        {
            return Naziv;
        }

        public int ObrisiSpecijalizaciju()
        {
            string upit = "DELETE FROM specijalizacija WHERE id = " + Id;
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }
    }
}
