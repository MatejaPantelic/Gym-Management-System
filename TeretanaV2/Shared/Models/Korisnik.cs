using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Korisnik
    {
        public int id_korisnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datum_rodjenja { get; set; }
        public decimal tezina { get; set; }
        public decimal visina { get; set; }
        public string pol { get; set; }
        public string email { get; set; }
        public int id_trenera { get; set; }
    }
}
