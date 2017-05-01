namespace MebeliGergana.Models.EntityModels
{
    public class Portmanto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] ImagePicture { get; set; }
        public string CatNumber { get; set; }
        public string Color { get; set; }
        public string Razmeri { get; set; }
        public virtual Supplier Supplier { get; set; }
        public string Type { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }

        public int? NalichnostBr { get; set; }
    }
}