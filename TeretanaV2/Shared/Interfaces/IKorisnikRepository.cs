using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IKorisnikRepository
    {
        List<Korisnik> ListaKorisnika();
        int UpdateKorisnik(Korisnik korisnik);
        int DeleteKorisnik(int id_korisnika);
        int InsertKorisnik(Korisnik k);
    }
}
