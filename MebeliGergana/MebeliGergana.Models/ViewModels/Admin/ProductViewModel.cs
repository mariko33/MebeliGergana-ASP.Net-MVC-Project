using System.ComponentModel.DataAnnotations;

namespace MebeliGergana.Models.ViewModels.Admin
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Display(Name = "Цвят")]
        public string Color { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}