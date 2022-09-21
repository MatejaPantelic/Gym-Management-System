using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IKorisnikBusiness
    {
        List<Korisnik> ListaKorisnika();
        string UpdateKorisnik(Korisnik korisnik);
        string DeleteKorisnik(int id_korisnika);
        bool InsertKorisnk(Korisnik k);
    }
}
