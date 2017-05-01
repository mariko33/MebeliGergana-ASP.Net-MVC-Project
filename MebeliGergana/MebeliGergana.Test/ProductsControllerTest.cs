using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebeliGergana.Data.Interfaces;
using MebeliGergana.Data.Mocks;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Models.ViewModels.Admin;
using MebeliGergana.Services.AdminSereces;
using MebeliGergana.Services.Interfaces;
using MebeliGergana.Services.TestServices;
using MebeliGergana.Web.Areas.Admin.Controllers;
using MebeliGergana.Web.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace MebeliGergana.Test
{
    [TestClass]
  public class ProductsControllerTest
    {
        private ProductsController controller;
        private IProductsServices service;
        private void ConfigureMapper()
        {
            MappConfig.ConfigerMapping();
            
        }
        //private List<Spalnq> spalni;
        //private IMebeliGerganaContext context;
        //private List<Supplier> suppliers;
        //private IzdeliqBindingModel model;


        //[TestInitialize]
        //public void Init()
        //{
        //    this.model=new IzdeliqBindingModel()
        //    {
        //        Name = "ВиченцаTest",
        //        Color = "бяло гланц 18/ черно огледален гланц 18/ еко кожа (18мм ПДЧ)",
        //        Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш225см  /система Hettich, Germany/",
        //        Price = 1399,
        //        //Supplier = context.Suppliers.Find(1),
        //        // ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+ "Images/Apolo/Spalni/VichencaB&W.jpg"),
        //        Type = "Спален комплектProba"
        //    };
        //    this.suppliers=new List<Supplier>()
        //    {
        //        new Supplier()
        //        {
        //            Name = "GoldApolo",
        //            Telephone = "898678975"
        //        }
        //    };


        //    this.spalni = new List<Spalnq>()
        //    {
        //        new Spalnq()
        //        {
        //            Name = "Виктория",
        //            Color = "бяло 16/ черно 16/ бял лакобел",
        //            Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш180см ",
        //            Price = 1274,
        //            //Supplier=context.Suppliers.Find(1),
        //            //ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/victoriq3.jpg"),
        //            Type = "Спален комплект"

        //        },
        //        new Spalnq()
        //        {

        //            Name = "Виченца",
        //            Color = "бяло гланц 18/ черно огледален гланц 18/ еко кожа (18мм ПДЧ)",
        //            Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш225см  /система Hettich, Germany/",
        //            Price = 1399,
        //            //Supplier = context.Suppliers.Find(1),
        //           // ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+ "Images/Apolo/Spalni/VichencaB&W.jpg"),
        //            Type = "Спален комплект"
        //        }
        //    };

        //    this.context = new FackeMebeliGerganaContext();

        //    foreach (var spalnq in spalni)
        //    {
        //        this.context.Spalni.Add(spalnq);

        //    }

        //    foreach (var supplier in suppliers)
        //    {
        //        this.context.Suppliers.Add(supplier);
        //    }
        //    this.service = new ProductsServicesTest();
        //    this.ConfigureMapper();
        //    this.controller=new ProductsController(this.service);

        //}
        [TestInitialize]
        public void Init()
        {
            this.service=new ProductsServices();
            this.controller=new ProductsController(this.service);
            this.ConfigureMapper();

        }

        [TestMethod]
        public void Spalni_Admin_ShouidPass()
        {
            this.controller.WithCallTo(h => h.Spalni()).ShouldRenderDefaultView()
                .WithModel<ICollection<ProductViewModel>>();
        }

        [TestMethod]
        public void CreateSpalni_Admin_ShouldPass()
        {
            
            this.controller.WithCallTo(h => h.CreateSpalni()).ShouldRenderDefaultView();


        }

        [TestMethod]
        public void Detsci_Admin_ShouidPass()
        {
            this.controller.WithCallTo(h => h.Detski()).ShouldRenderDefaultView()
                .WithModel<ICollection<ProductViewModel>>();
        }

        [TestMethod]
        public void CreateDetsci_Admin_ShouldPass()
        {

            this.controller.WithCallTo(h => h.CreateDetski()).ShouldRenderDefaultView();


        }

    }
}

