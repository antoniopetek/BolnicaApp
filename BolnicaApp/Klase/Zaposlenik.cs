using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BolnicaApp.Klase
{
    public class Zaposlenik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int Tip_Zaposlenika_Id { get; set; }
        public int Bolnica_Id { get; set; }
        public int Specijalizacija_Id { get; set; }
        public static Zaposlenik PrijavljeniZaposlenik { get; set; }
        public string PunoIme
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }

        public Zaposlenik()
        {

        }

        public Zaposlenik(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Ime = dr["ime"].ToString();
                Prezime = dr["prezime"].ToString();
                Email = dr["email"].ToString();
                Kontakt = dr["kontakt"].ToString();
                Drzava = dr["drzava"].ToString();
                Grad = dr["grad"].ToString();
                Ulica = dr["ulica"].ToString();
                Broj = dr["broj"].ToString();
                KorisnickoIme = dr["korisnickoime"].ToString();
                Lozinka = dr["lozinka"].ToString();
                Tip_Zaposlenika_Id = int.Parse(dr["tip_zaposlenika_id"].ToString());
                Bolnica_Id = int.Parse(dr["bolnica_id"].ToString());
                Specijalizacija_Id = int.Parse(dr["specijalizacija_id"].ToString());
            }
        }

        public static Zaposlenik DohvatiZaposlenika(string korisnickoIme, string lozinka)
        {
            Zaposlenik zaposlenik = null;
            string sqlUpit = "SELECT * FROM zaposlenik WHERE korisnickoime = '" + korisnickoIme + "' AND lozinka = '" + lozinka + "' LIMIT 1;";
            NpgsqlDataReader dr = Klase.Baza.Instanca.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                zaposlenik = new Zaposlenik(dr);
            }

            dr.Close();
            return zaposlenik;
        }

        public static List<Zaposlenik> DohvatiSveZaposlenike()
        {
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
            string upit = "SELECT * FROM zaposlenik ORDER BY id;";

            NpgsqlDataReader dr = Klase.Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                Zaposlenik z = new Zaposlenik(dr);
                zaposlenici.Add(z);
            }

            dr.Close();
            return zaposlenici;
        }

        public int ObrisiZaposlenika(int id)
        {
            string upit = "DELETE FROM zaposlenik WHERE id = " + id;
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
