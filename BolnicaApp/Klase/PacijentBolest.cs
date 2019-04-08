using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class PacijentBolest
    {
        public int ID { get; set; }
        public string Naziv_Bolesti { get; set; }
        public string Opis_Stanja { get; set; }
       

        public PacijentBolest(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                ID = int.Parse(dr["id"].ToString());
                Naziv_Bolesti = dr["naziv"].ToString();
                Opis_Stanja = dr["opisstanja"].ToString();
            }
        }

        public static List<PacijentBolest> DohvatiPovijestBolesti(int id)
        {
            List<PacijentBolest> lista = new List<PacijentBolest>();
            string upit = "SELECT pb.id, b.naziv, pb.opisstanja FROM bolest b, povijest_bolesti pb, pacijent pa WHERE pb.pacijent_id = pa.id AND pb.bolest_id = b.id AND pa.id = " + id + ";";
            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                PacijentBolest pb = new PacijentBolest(dr);
                lista.Add(pb);
            }

            dr.Close();
            return lista;
        }
    }
}
