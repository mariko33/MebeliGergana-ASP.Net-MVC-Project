using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebeliGergana.Models.BindingModels
{
   public class PorachkaBindingModel
    {
        [Required]
        public int IzdelieId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Izdelie { get; set; }

        [Required(ErrorMessage = "Изберете количество")]
        public int Broi { get; set; }

        [Required]
        public string ClientId { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        public string LastName { get; set; }

        [Display(Name = "Телефон")]
        [Phone(ErrorMessage = "Въведете валиден телефонен номер")]
        [Required(ErrorMessage = "Полето е задължително")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        public string Adress { get; set; }

        //[Required(ErrorMessage = "Полето е задължително")]
        //[EmailAddress(ErrorMessage = "Въведете валиден имейл")]
        //public string Email { get; set; }

    }
}
