using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebeliGergana.Models.ViewModels.Admin
{
   public class EditSupplierViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Display(Name = "Телефон")]
        public string Telephone { get; set; }
    }
}
