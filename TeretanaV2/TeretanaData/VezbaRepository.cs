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
    public class VezbaRepository:IVezbaRepository
    {
        public List<Vezba> CitanjeVezbi()
        {

            SqlConnection konekcija = new SqlConnection(Constants.connString);
            konekcija.Open();

            SqlCommand komanda = new SqlCommand();
            komanda.Connection = konekcija;
            komanda.CommandText = "SELECT* FROM Vezbe ";
            SqlDataReader dataReader = komanda.ExecuteReader();
            List<Vezba> listaVezbi = new List<Vezba>();

            while (dataReader.Read())
            {
                Vezba v = new Vezba();
                v.id_vezbe = dataReader.GetInt32(0);
                v.naziv = dataReader.GetString(1);
                v.regija_tela = dataReader.GetString(2);
                v.broj_serija = dataReader.GetInt32(3);
                v.broj_ponavljanja = dataReader.GetInt32(4);
                if (dataReader.IsDBNull(5))
                    v.id_trenera = -1;
                else
                    v.id_trenera = dataReader.GetInt32(5);
                listaVezbi.Add(v);

            }
            konekcija.Close();
            return listaVezbi;
        }
    }
}
