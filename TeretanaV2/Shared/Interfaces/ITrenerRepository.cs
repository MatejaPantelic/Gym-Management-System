using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface ITrenerRepository
    {
        List<Trener> PrijavaTrenera();
        int InsertTrener(Trener t);

    }
}
