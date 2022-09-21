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
    //metoda koja vraca listu korisnika iz baze
    public class KorisnikRepository:IKorisnikRepository
    {
            public List<Korisnik> ListaKorisnika()
            {
                List<Korisnik> lista = new List<Korisnik>();
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT* FROM Korisnici";
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Korisnik k = new Korisnik();
                        k.id_korisnika = sqlDataReader.GetInt32(0);
                        k.ime = sqlDataReader.GetString(1);
                        k.prezime = sqlDataReader.GetString(2);
                        k.datum_rodjenja = sqlDataReader.GetDateTime(3);
                        k.tezina = sqlDataReader.GetDecimal(4);
                        k.visina = sqlDataReader.GetDecimal(5);
                        k.pol = sqlDataReader.GetString(6);
                        k.email = sqlDataReader.GetString(7);
                        k.id_trenera = sqlDataReader.GetInt32(8);
                        lista.Add(k);
                    }
                }
                return lista;
            }

        //metoda za azuriranje podataka o korisnicima u bazi
        public int UpdateKorisnik(Korisnik korisnik)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                string sqlCommand = "UPDATE Korisnici SET ime = @ime, prezime = @prezime, datum_rodjenja = @datum_rodjenja, tezina=@tezina, visina=@visina, pol=@pol, email=@email, id_trenera=@id_trenera WHERE id_korisnika = @id_korisnika";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@ime", korisnik.ime);
                command.Parameters.AddWithValue("@prezime", korisnik.prezime);
                command.Parameters.AddWithValue("@datum_rodjenja", korisnik.datum_rodjenja);
                command.Parameters.AddWithValue("@tezina", korisnik.tezina);
                command.Parameters.AddWithValue("@visina", korisnik.visina);
                command.Parameters.AddWithValue("@pol", korisnik.pol);
                command.Parameters.AddWithValue("@email", korisnik.email);
                command.Parameters.AddWithValue("@id_trenera", korisnik.id_trenera);
                command.Parameters.AddWithValue("@id_korisnika", korisnik.id_korisnika);
                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        //metoda koja brise korisnika iz baze
        public int DeleteKorisnik(int id_korisnika)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Korisnici WHERE id_korisnika = " + id_korisnika;

                return command.ExecuteNonQuery();
            }
        }

        //metoda za ubacivanje/pamcenje korisnika
        public int InsertKorisnik(Korisnik k)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Korisnici VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    k.ime, k.prezime, k.datum_rodjenja, k.tezina, k.visina, k.pol, k.email, k.id_trenera);
                
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
