using Rolloffsample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rolloffsample.Services
{
    public interface IRollOffService
    {
        Task<IEnumerable<RollOffTable>> Find();
        Task<RollOffTable> SearchbyGGid(double ggid);
    }
}
