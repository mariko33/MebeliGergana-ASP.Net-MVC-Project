using System.ComponentModel.DataAnnotations;
using MebeliGergana.Models.EntityModels;

namespace MebeliGergana.Models.ViewModels.Admin
{
    public class FullProductViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Име")]
        public string Name { get; set; }
        [Display(Name = "Снимка")]
        public byte[] ImagePicture { get; set; }
        [Display(Name = "Номер от каталог")]
        public string CatNumber { get; set; }

        [Display(Name = "Цвят")]
        public string Color { get; set; }

        [Display(Name = "Размери")]
        public string Razmeri { get; set; }

        [Display(Name = "Доставчик")]
        public virtual Supplier Supplier { get; set; }

        [Display(Name = "Вид изделие")]
        public string Type { get; set; }

        [Display(Name = "Цена")]
        public decimal? Price { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Наличност")]

        public int? NalichnostBr { get; set; }
    }
}