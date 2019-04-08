using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BolnicaApp.Klase
{
    class Baza
    {
        private static Baza instanca;
        private string connectionString;
        private NpgsqlConnection connection;

        public static Baza Instanca
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new Baza();
                }
                return instanca;
            }
        }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            private set
            {
                connectionString = value;
            }
        }

        public NpgsqlConnection Connection
        {
            get
            {
                return connection;
            }
            private set
            {
                connection = value;
            }
        }

        private Baza()
        {
            ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=antonio;Database=DBbolnica";
            Connection = new NpgsqlConnection(ConnectionString);
            Connection.Open();
        }

        ~Baza()
        {
            Connection.Close();
            Connection = null;
        }

        public NpgsqlDataReader DohvatiDataReader(string sqlUpit)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
