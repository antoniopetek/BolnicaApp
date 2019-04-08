using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    public class Pacijent
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public string PunoIme
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }

        public Pacijent()
        {

        }

        public Pacijent(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Ime = dr["ime"].ToString();
                Prezime = dr["prezime"].ToString();
                DatumRodenja = DateTime.Parse(dr["datumrodenja"].ToString());
                Email = dr["email"].ToString();
                Kontakt = dr["kontakt"].ToString();
                Drzava = dr["drzava"].ToString();
                Grad = dr["grad"].ToString();
                Ulica = dr["ulica"].ToString();
                Broj = dr["broj"].ToString();             
            }
        }

        public static List<Pacijent> DohvatiPacijente()
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            string upit = "SELECT * FROM pacijent;";

            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                Pacijent p = new Pacijent(dr);
                pacijenti.Add(p);
            }

            dr.Close();
            return pacijenti;
        }
        public int ObrisiPacijenta()
        {
            string upit = "DELETE FROM pacijent WHERE id = " + Id;
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
