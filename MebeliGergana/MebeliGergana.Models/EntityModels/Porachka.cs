using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebeliGergana.Models.EntityModels
{
   public class Porachka
    {
        public int Id { get; set; }

        public string IzdelieDescription { get; set; }

        public int Kolichestvo { get; set; }

        public decimal FinalPrice { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual ApplicationUser Client { get; set; }

        //public string PorachkaEmail { get; set; }

        public string PorachkaFullName { get; set; }

        public string PorachkaPhoneNumber { get; set; }

        public string PorachkaAdress { get; set; }

        public bool IsActive { get; set; }
    }
}
