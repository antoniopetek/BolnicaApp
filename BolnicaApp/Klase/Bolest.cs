using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    public class Bolest
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public Bolest()
        {

        }

        public Bolest(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();
            }
        }

        public static List<Bolest> DohvatiSveBolesti()
        {
            List<Bolest> bolesti = new List<Bolest>();
            string upit = "SELECT * FROM bolest;";

            NpgsqlDataReader dr = Klase.Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                Bolest b = new Bolest(dr);
                bolesti.Add(b);
            }

            dr.Close();
            return bolesti;
        }

        public int DodajBolest()
        {
            string upit = "INSERT INTO bolest VALUES ('" + Naziv + "';";
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }

        public int ObrisiBolest(int id)
        {
            string upit = "DELETE FROM bolest WHERE id = " + id;
            return Klase.Baza.Instanca.IzvrsiUpit(upit);
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
