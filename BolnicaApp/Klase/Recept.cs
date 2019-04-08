using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BolnicaApp.Klase
{
    class Recept
    {
        public int Id { get; set; }
        public int Doktor_Id { get; set; }
        public int Pacijent_Id { get; set; }
        public DateTime DatumIzdavanja { get; set; }

        public Recept()
        {

        }

        public Recept(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Doktor_Id = int.Parse(dr["doktor_id"].ToString());
                Pacijent_Id = int.Parse(dr["pacijent_id"].ToString());
                DatumIzdavanja = DateTime.Parse(dr["datumizdavanja"].ToString());
            }
        }

        public static Recept DohvatiRecept()
        {
            Recept recept = null;
            string upit2 = "SELECT * FROM recept ORDER BY 1 DESC LIMIT 1";
            NpgsqlDataReader dr = Klase.Baza.Instanca.DohvatiDataReader(upit2);
            while (dr.Read())
            {
                recept = new Recept(dr);
            }
            dr.Close();
            return recept;
        }
    }
}
