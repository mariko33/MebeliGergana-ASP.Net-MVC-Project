using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MebeliGergana.Models.EntityModels;
using System.Web;
using System.Drawing;
using System.Net.Mime;
using MebeliGergana.Models.Attributes;

namespace MebeliGergana.Models.BindingModels
{
  public class IzdeliqBindingModel
    {
        //public string Name { get; set; }
        //public HttpPostedFileBase ImageName { get; set; }
        //public string CatNumber { get; set; }
        //public string Color { get; set; }
        //public string Razmeri { get; set; }
        //public int SupplierId { get; set; }
        //public string Type { get; set; }
        //public decimal Price { get; set; }
        //public string Description { get; set; }
        //public int NalichnostBr { get; set; }



        [Required]
        public string Name { get; set; }
        [ValidateFile]
        public HttpPostedFileBase ImageName { get; set; }
        public string CatNumber { get; set; }
        [Required]
        public string Color { get; set; }
        public string Razmeri { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public string Type { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int NalichnostBr { get; set; }


    }
}
