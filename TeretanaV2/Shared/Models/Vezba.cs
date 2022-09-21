using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Vezba
    {
        public int id_vezbe { get; set; }
        public string naziv { get; set; }
        public string regija_tela { get; set; }
        public int broj_serija { get; set; }
        public int broj_ponavljanja { get; set; }
        public decimal visina { get; set; }
        public int id_trenera { get; set; }
    }
}
