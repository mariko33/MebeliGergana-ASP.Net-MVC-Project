using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebeliGergana.Models.EntityModels;

namespace MebeliGergana.Models.ViewModels
{
   public class DetailsViewModel
    {

        public int Id { get; set; }
        [Display(Name = "Име")]
        public string Name { get; set; }
        public byte[] ImagePicture { get; set; }
        [Display(Name = "Цвят")]
        public string Color { get; set; }
     
        public int  SupplierId { get; set; }
        [Display(Name = "Вид")]
        public string Type { get; set; }
        [Display(Name = "Цена")]
        public decimal? Price { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }

    }
}
