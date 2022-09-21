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
    public class TrenerBusiness : ITrenerBusiness
    {
        private readonly ITrenerRepository tRepo;
        public TrenerBusiness(ITrenerRepository _itrenerRepository)
        {
            tRepo = _itrenerRepository;
        }
        public  List<Trener> VratiTrenere()
        {
            return this.tRepo.PrijavaTrenera();
        }
        public bool InsertTrener(Trener t)
        {
            if(this.tRepo.InsertTrener(t)>0)
            {
                return true;
            }
            return false;
        }
    }
}
