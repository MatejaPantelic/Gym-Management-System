using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeretanaData;
using Shared.Models;
using Shared.Interfaces;

namespace TeretanaBusiness
{
    public class VezbaBusiness:IVezbaBusiness
    {
        private readonly IVezbaRepository vezbaRepository;
        public VezbaBusiness(IVezbaRepository _ivezbaRepository)
        {
            vezbaRepository = _ivezbaRepository;
        }
        public List<Vezba> CitanjeVezbi()
        {
            return this.vezbaRepository.CitanjeVezbi();
        }
    }
}
