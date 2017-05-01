using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MebeliGergana.Data.Interfaces;
using MebeliGergana.Data.Mocks;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Services;
using MebeliGergana.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MebeliGergana.Web.Controllers;
using MebeliGergana.Web.Helpers;
using TestStack.FluentMVCTesting;

namespace MebeliGergana.Test
{
    [TestClass]
   public class IzdeliqControllerTest
    {
        private IzdeliqController controller;
        private IIzdeliqServices service;
        //private IMebeliGerganaContext context;
        //private List<Spalnq> spalni;




        private void ConfigureMapper()
        {
            MappConfig.ConfigerMapping();
            //Mapper.Initialize(expression =>
            //{
            //    expression.CreateMap<Detska, IzdeliqViewModel>();
            //    expression.CreateMap<Sekciq, IzdeliqViewModel>();
            //    expression.CreateMap<Portmanto, IzdeliqViewModel>();
            //});
        }

        [TestInitialize]
        public void Init()
        {
            //this.spalni=new List<Spalnq>()
            //{
            //    new Spalnq()
            //    {
            //        Name = "Виктория",
            //        Color = "бяло 16/ черно 16/ бял лакобел",
            //        Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш180см ",
            //        Price = 1274,
            //        //Supplier=context.Suppliers.Find(1),
            //        //ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/victoriq3.jpg"),
            //        Type = "Спален комплект"

            //    },
            //    new Spalnq()
            //    {

            //        Name = "Виченца",
            //        Color = "бяло гланц 18/ черно огледален гланц 18/ еко кожа (18мм ПДЧ)",
            //        Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш225см  /система Hettich, Germany/",
            //        Price = 1399,
            //        //Supplier = context.Suppliers.Find(1),
            //       // ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+ "Images/Apolo/Spalni/VichencaB&W.jpg"),
            //        Type = "Спален комплект"
            //    }
            //};

            //this.context = new FackeMebeliGerganaContext();
            //foreach (var spalnq in spalni)
            //{
            //    this.context.Spalni.Add(spalnq);

            //}
            this.service=new IzdeliqServices();
            this.controller=new IzdeliqController(this.service);
            this.ConfigureMapper();


        }

        //public IzdeliqControllerTest()
        //{
        //    this.service=new IzdeliqServices();
        //    this.controller=new IzdeliqController(this.service);
            
        //}

        [TestMethod]
        public void Spalni_ShouldPass()
        {
            this.controller.WithCallTo(h => h.Spalni()).ShouldRenderDefaultView()
                .WithModel<ICollection<IzdeliqViewModel>>();
        }

        [TestMethod]
        public void Detsci_ShouldPass()
        {
            this.controller.WithCallTo(h => h.Detsci()).ShouldRenderDefaultView()
               .WithModel<ICollection<IzdeliqViewModel>>();
        }

        [TestMethod]
        public void Sekcii_ShouldPass()
        {
            this.controller.WithCallTo(h => h.Sekcii()).ShouldRenderDefaultView()
                .WithModel<ICollection<IzdeliqViewModel>>();
        }

        [TestMethod]
        public void Portmanta_ShouidPass()
        {
            this.controller.WithCallTo(h => h.Portmanta()).ShouldRenderDefaultView()
                .WithModel<ICollection<IzdeliqViewModel>>();
        }

        [TestMethod]
        public void Kuhni_ShouidPass()
        {
            this.controller.WithCallTo(h => h.Kuhni()).ShouldRenderDefaultView()
                .WithModel<ICollection<IzdeliqViewModel>>();
        }

        [TestMethod]
        public void Masi_ShouidPass()
        {
            this.controller.WithCallTo(h => h.Masi()).ShouldRenderDefaultView()
                .WithModel<ICollection<IzdeliqViewModel>>();
        }

        [TestMethod]
        public void Details_ShouidPass()
        {
            this.controller.WithCallTo(h => h.Details(1,"Spalnq")).ShouldRenderDefaultView()
                .WithModel<DetailsViewModel>();
        }

    }
}
