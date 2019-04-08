using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class Pregled
    {
        public int Id { get; set; }
        public int Doktor_Id { get; set; }
        public int Pacijent_Id { get; set; }
        public int VrstaPregleda { get; set; }
        public DateTime DatumPregleda { get; set; }
        public string Opis { get; set; }

        public Pregled()
        {

        }

        public Pregled(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Doktor_Id = int.Parse(dr["doktor_id"].ToString());
                Pacijent_Id = int.Parse(dr["pacijent_id"].ToString());
                VrstaPregleda = int.Parse(dr["vrstapregleda"].ToString());
                DatumPregleda = DateTime.Parse(dr["datumpregleda"].ToString());
                Opis = dr["opis"].ToString();
            }
        }
    }
}
