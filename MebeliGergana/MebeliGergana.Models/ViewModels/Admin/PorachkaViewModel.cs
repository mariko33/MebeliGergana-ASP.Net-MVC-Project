using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebeliGergana.Models.EntityModels;

namespace MebeliGergana.Models.ViewModels.Admin
{
   public class PorachkaViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Описание")]
        public string IzdelieDescription { get; set; }

        [Display(Name = "Количеств")]
        public int Kolichestvo { get; set; }

        [Display(Name = "Цена")]
        public decimal FinalPrice { get; set; }

        [Display(Name = "Доставчик")]
        public Supplier Supplier { get; set; }

        public ApplicationUser Client { get; set; }

        [Display(Name = "Име Клиент")]
        public string PorachkaFullName { get; set; }

        [Display(Name = "Телефон")]
        public string PorachkaPhoneNumber { get; set; }

        [Display(Name = "Адрес")]
        public string PorachkaAdress { get; set; }

        [Display(Name = "Активност")]
        public bool IsActive { get; set; }
    }
}
