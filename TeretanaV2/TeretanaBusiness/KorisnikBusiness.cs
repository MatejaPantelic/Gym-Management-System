using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeretanaData;
using Shared.Interfaces;

namespace TeretanaBusiness
{
    public class KorisnikBusiness:IKorisnikBusiness
    {
        private readonly IKorisnikRepository korisnikRepository;
        public KorisnikBusiness(IKorisnikRepository _ikorisnikRepository)
        {
            korisnikRepository = _ikorisnikRepository;
        }

        //metoda za vracanje liste korisnika iz baze
        public List<Korisnik> ListaKorisnika()
        {
            return this.korisnikRepository.ListaKorisnika();
        }

        //metoda za azuriranje podataka o korisnicima u bazi
        public string UpdateKorisnik(Korisnik korisnik)
         {
             int rowsAffected = this.korisnikRepository.UpdateKorisnik(korisnik);

             if (rowsAffected > 0)
             {
                 return "Izmena uspešna!";
             }
             else
             {
                 return "Neuspešna izmena!";
             }
         }

        //metoda za brisanje korisnika iz baze
        public string DeleteKorisnik(int id_korisnika)
        {
            int rowsAffected = this.korisnikRepository.DeleteKorisnik(id_korisnika);

            if (rowsAffected > 0)
            {
                return "Korisnik je obrisan iz baze podataka!";
            }
            else
            {
                return "Brisanje korisnika nije uspelo!";
            }
        }

        //metoda za ubacivanje/pamcenje korisnika
        public bool InsertKorisnk(Korisnik k)
        {
            if (this.korisnikRepository.InsertKorisnik(k) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
