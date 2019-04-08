using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class PovijestBolesti
    {
        public int Id { get; set; }
        public int Pacijent_Id { get; set; }
        public int Bolest_Id { get; set; }
        public string OpisStanja { get; set; }

        public PovijestBolesti()
        {

        }

        public PovijestBolesti(NpgsqlDataReader dr)
        {
            Id = int.Parse(dr["id"].ToString());
            Pacijent_Id = int.Parse(dr["pacijent_id"].ToString());
            Bolest_Id = int.Parse(dr["bolest_id"].ToString());
            OpisStanja = dr["opisstanja"].ToString();
        }
    }
}
