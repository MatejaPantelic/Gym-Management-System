using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Trener
    {
        public int id_trenera { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datum_rodjenja { get; set; }
        public string strucna_oblast { get; set; }
        public string br_telefona { get; set; }
        public string biografija { get; set; }
        public string korisnicko_ime { get; set; }
        public string sifra { get; set; }
    }
}
