using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface ITrenerBusiness
    {
        List<Trener> VratiTrenere();
        bool InsertTrener(Trener t);
    }
}
