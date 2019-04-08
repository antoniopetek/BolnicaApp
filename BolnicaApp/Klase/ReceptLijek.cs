using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class ReceptLijek
    {
        public int Recept_Id { get; set; }
        public string Naziv_Lijeka { get; set; }

        public ReceptLijek()
        {

        }

        public ReceptLijek(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                Recept_Id = int.Parse(dr["id"].ToString());
                Naziv_Lijeka = dr["naziv"].ToString();
            }
        }

        public static List<ReceptLijek> DohvatiLijekoveNaReceptu(int id)
        {
            List<ReceptLijek> lista = new List<ReceptLijek>();
            string upit = "SELECT r.id, l.naziv FROM recept r, lijek l, recept_lijek rl WHERE r.id = " + id + " AND r.id = rl.recept_id AND rl.lijek_id = l.id";
            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                ReceptLijek rl = new ReceptLijek(dr);
                lista.Add(rl);
            }

            dr.Close();
            return lista;
        }
    }
}
