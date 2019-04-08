using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolnicaApp.Klase
{
    class PregledRecepata
    {
        public int ID { get; set; }
        private string ImeDoktora { get; set; }
        private string PrezimeDoktora { get; set; }
        private string ImePacijenta { get; set; }
        private string PrezimePacijenta { get; set; }
        public DateTime Datum { get; set; }
        public string Doktor
        {
            get
            {
                return ImeDoktora + " " + PrezimeDoktora;
            }
        }
        public string Pacijent
        {
            get
            {
                return ImePacijenta + " " + PrezimePacijenta;
            }
        }

        public PregledRecepata(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                ID = int.Parse(dr["id"].ToString());
                ImeDoktora = dr["ime"].ToString();
                PrezimeDoktora = dr["prezime"].ToString();
                ImePacijenta = dr["ime1"].ToString();
                PrezimePacijenta = dr["prezime1"].ToString();
                Datum = DateTime.Parse(dr["datumizdavanja"].ToString());
            }
        }

        public static List<PregledRecepata> DohvatiRecepte()
        {
            List<PregledRecepata> lista = new List<PregledRecepata>();
            string upit = "SELECT r.id, z.ime, z.prezime, p.ime AS " + "ime1" + ", p.prezime AS " + "prezime1" + ", r.datumizdavanja FROM zaposlenik z, pacijent p, recept r WHERE z.id = r.doktor_id AND r.pacijent_id = p.id";
            NpgsqlDataReader dr = Baza.Instanca.DohvatiDataReader(upit);

            while (dr.Read())
            {
                PregledRecepata pr = new PregledRecepata(dr);
                lista.Add(pr);
            }

            dr.Close();
            return lista;
        }
    }
}
