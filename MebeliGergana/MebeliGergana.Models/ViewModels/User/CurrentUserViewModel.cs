using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebeliGergana.Models.ViewModels.User
{
   public class CurrentUserViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Име")]
        [Required(ErrorMessage = "Полето е задължително")]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Полето е задължително")]
        public string LastName { get; set; }
        [Display(Name = "Телефон")]
        [Phone(ErrorMessage = "Въведете валиден телефонен номер")]
        [Required(ErrorMessage = "Полето е задължително")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Полето е задължително")]
        public string Adress { get; set; }
        [Display(Name = "Имейл")]
        [Required(ErrorMessage = "Полето е задължително")]
        [EmailAddress(ErrorMessage = "Въведете валиден имейл")]
        public string Email { get; set; }
    }
}
