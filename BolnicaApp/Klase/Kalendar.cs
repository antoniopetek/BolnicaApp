using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class Kalendar
    {
        public int Id { get; set; }
        public int Pregled_Id { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Zavrsetak { get; set; }

        public Kalendar()
        {

        }

        public Kalendar(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Pregled_Id = int.Parse(dr["pregled_id"].ToString());
                Pocetak = DateTime.Parse(dr["pocetak"].ToString());
                Zavrsetak = DateTime.Parse(dr["zavrsetak"].ToString());
            }
        }
    }
}
