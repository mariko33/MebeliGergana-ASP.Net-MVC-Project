using System.ComponentModel.DataAnnotations;

namespace MebeliGergana.Models.ViewModels.Admin
{
    public class DeleteProductViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}