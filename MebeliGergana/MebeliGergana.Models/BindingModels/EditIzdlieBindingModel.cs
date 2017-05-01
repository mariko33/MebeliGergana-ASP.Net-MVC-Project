using System.Web;
using MebeliGergana.Models.Attributes;

namespace MebeliGergana.Models.BindingModels
{
    public class EditIzdlieBindingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ValidateFile]
        public HttpPostedFileBase ImageName { get; set; }
        public string CatNumber { get; set; }
        public string Color { get; set; }
        public string Razmeri { get; set; }
        public int SupplierId { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int NalichnostBr { get; set; }
    }
}