using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    public class Bolnica
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }

        public Bolnica()
        {

        }

        public Bolnica(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();     
                Drzava = dr["drzava"].ToString();
                Grad = dr["grad"].ToString();
                Ulica = dr["ulica"].ToString();
                Broj = dr["broj"].ToString();          
            }
        }

        public static Bolnica DohvatiBolnicu(int id)
        {
            Bolnica bolnica = null;
            string upit = "SELECT * FROM bolnica WHERE id = '" + id + "' LIMIT 1";

            NpgsqlDataReader dr = Klase.Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                bolnica = new Bolnica(dr);
            }

            dr.Close();
            return bolnica;
        }

        public static List<Bolnica> DohvatiBolnice()
        {
            List<Bolnica> bolnice = new List<Bolnica>();
            string upit = "SELECT * FROM bolnica";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                Bolnica b = new Bolnica(dr);
                bolnice.Add(b);
            }

            dr.Close();
            return bolnice;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
