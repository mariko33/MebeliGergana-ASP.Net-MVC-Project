using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebeliGergana.Models.EntityModels;

namespace MebeliGergana.Data.Mocks
{
   public class FackeSpalniDbSet:FackeDbSet<Spalnq>
    {
        public override Spalnq Find(params object[] keyValues)
        {
            int wantedId = (int)keyValues[0];
            return this.Set.FirstOrDefault(car => car.Id == wantedId);
        }
    }
}
