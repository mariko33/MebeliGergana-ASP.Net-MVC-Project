using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebeliGergana.Models.EntityModels
{
  public class Supplier
    {
        public Supplier()
        {
            this.Spalni=new HashSet<Spalnq>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<Spalnq>Spalni { get; set; }
    }
}
