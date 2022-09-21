using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Shared.Models;
using Shared.Interfaces;

namespace TeretanaData
{
    public class TrenerRepository:ITrenerRepository
    {
        public List<Trener> PrijavaTrenera()
        {
            
            SqlConnection konekcija = new SqlConnection(Constants.connString);
            konekcija.Open();

            SqlCommand komanda = new SqlCommand();
            komanda.Connection = konekcija;
            komanda.CommandText = "SELECT* FROM Treneri ";
            SqlDataReader dataReader = komanda.ExecuteReader();
            List<Trener> listaTrenera = new List<Trener>();

            while(dataReader.Read())
            {
                Trener t = new Trener();
                t.id_trenera = dataReader.GetInt32(0);
                t.ime = dataReader.GetString(1);
                t.prezime = dataReader.GetString(2);
                t.datum_rodjenja = dataReader.GetDateTime(3);
                t.strucna_oblast = dataReader.GetString(4);
                t.br_telefona = dataReader.GetString(5);
                if (dataReader.IsDBNull(6))
                    t.biografija = "";
                else
                    t.biografija = dataReader.GetString(6);
                t.korisnicko_ime = dataReader.GetString(7);
                t.sifra = dataReader.GetString(8);
                listaTrenera.Add(t);
            }
            konekcija.Close();
            return listaTrenera;
        }

        //metoda za unos trenera u bazu
        public int InsertTrener(Trener t)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Treneri VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    t.ime,t.prezime,t.datum_rodjenja,t.strucna_oblast,t.br_telefona,t.biografija,t.korisnicko_ime,t.sifra);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
