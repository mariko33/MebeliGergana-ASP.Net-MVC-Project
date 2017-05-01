using MebeliGergana.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Services.Interfaces;
using Microsoft.AspNet.Identity;
using PagedList;

namespace MebeliGergana.Web.Controllers
{
    [RoutePrefix("Izdeliq")]
    public class IzdeliqController : Controller
    {

        private IIzdeliqServices service;

        public IzdeliqController(IIzdeliqServices service)
        {
            this.service=service;
        }


        // GET: Izdeliq
        [Route("Spalni")]
        public ActionResult Spalni(int page=1,int pageSize=3)
        {
            ICollection<IzdeliqViewModel> model = this.service.GetIzdeliqSpalnqModels();
            PagedList<IzdeliqViewModel> models = new PagedList<IzdeliqViewModel>(model, page, pageSize);
            return this.View(models);
        }

        [Route("Detsci")]
        public ActionResult Detsci(int page = 1, int pageSize = 3)
        {
            ICollection<IzdeliqViewModel> model = this.service.GetIzdeliqDetsciModel();
            PagedList<IzdeliqViewModel> models = new PagedList<IzdeliqViewModel>(model, page, pageSize);
            return this.View(models);
        }

        [Route("Sekcii")]
        public ActionResult Sekcii(int page=1, int pageSize=3)
        {
            ICollection<IzdeliqViewModel> model = this.service.GetIzdeliqSekciiModel();
            PagedList<IzdeliqViewModel> models = new PagedList<IzdeliqViewModel>(model, page, pageSize);
            return this.View(models);
        }

        [Route("Portmanta")]
        public ActionResult Portmanta(int page=1, int pageSize=3)
        {
            ICollection<IzdeliqViewModel> model = this.service.GetIzdeliqPortmantaModel();
            PagedList<IzdeliqViewModel> models = new PagedList<IzdeliqViewModel>(model, page, pageSize);
            return this.View(models);
        }


        [Route("Kuhni")]
        public ActionResult Kuhni(int page=1, int pageSize=3)
        {
            ICollection<IzdeliqViewModel> model = this.service.GetIzdeliqKuhniModel();
            PagedList<IzdeliqViewModel> models = new PagedList<IzdeliqViewModel>(model, page, pageSize);
            return this.View(models);
        }

        [Route("Masi")]
        public ActionResult Masi(int page=1, int pageSize=3)
        {
            ICollection<IzdeliqViewModel> model = this.service.GetIzdeliqMasiModel();
            PagedList<IzdeliqViewModel> models = new PagedList<IzdeliqViewModel>(model, page, pageSize);
            return this.View(models);

        }

        [Route("Details/{id}/{izdelie}")]
        [HttpGet]
        public ActionResult Details(int id,string izdelie)
        {
            DetailsViewModel model = this.service.GetDetailsViewModel(id, izdelie);
            ViewBag.Title = izdelie;
            return this.View(model);
        }

        //[Authorize(Roles = "User")]
        //public ActionResult PorachkaClient()
        //{
        //    string currentUserId = User.Identity.GetUserId();
        //    ApplicationUser currentUser = this.service.GetClient(currentUserId);

        //    return PartialView("_Client", currentUser);
        //}

        //[HttpGet]
        //[Route("Add")]
        //public ActionResult Add()
        //{
        //   ICollection<SuppliersViewModel> suppliers = service.GetSuppliers();
        //    return this.View(suppliers);
        //}

        //[HttpPost]
        //[Route("Add")]
        //public ActionResult Add([Bind(Include="CatNumber,Color,Description,Price,Name,Razmeri,Type,SupplierId,ImageName")]IzdeliqBindingModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        this.service.AddSpalnq(model);
        //     return this.RedirectToAction("Spalni");
        //    }
        //    return this.RedirectToAction("Add");

        //}
    }
}