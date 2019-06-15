using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodOleStLouie.Data
{
    interface ILocationRepository
    {
        List<Location> GetLocation();
        int Save(Location location);
        void Update(Location location);
        void Delete(int id);
    }
}
