using System.ComponentModel.DataAnnotations;

namespace MebeliGergana.Models.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Невалиден имейл.")]
        [Display(Name = "Имейл")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърди паролата")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Име")]
        
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
    }
}