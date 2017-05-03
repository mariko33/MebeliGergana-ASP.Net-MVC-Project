using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Models.ViewModels.Admin;
using MebeliGergana.Services.AdminSereces;
using MebeliGergana.Services.Interfaces;
using PagedList;

namespace MebeliGergana.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [RouteArea("Admin")]
    [RoutePrefix("Products")]
    public class ProductsController : Controller
    {
        private IProductsServices service;

        public ProductsController(IProductsServices service)
        {
            this.service=service;
        }

        // GET: Admin/Products
        [Route("Spalni")]
        public ActionResult Spalni()
        {
            ICollection<ProductViewModel> models = this.service.GetSpalniViewMoedel();
            return View(models);
        }

        [HttpGet]
        [Route("CreateSpalni")]
        public ActionResult CreateSpalni()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CreateSpalni")]
        public ActionResult CreateSpalni(
            [Bind(Include = "CatNumber,Color,Description,Price,Name,Razmeri,Type,ImageName,NalichnostBr")] IzdeliqBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.AddSpalnq(model);
                return this.RedirectToAction("Spalni");
            }
            return this.RedirectToAction("CreateSpalni");

        }

        [HttpGet]
        [Route("EditSpalni/{id}")]
        public ActionResult EditSpalni(int id)
        {
            FullProductViewModel model = this.service.GetSpalnqById(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditSpalni/{id}")]
        public ActionResult EditSpalni([Bind(Include = "Id,CatNumber,Color,Description,Price,Name,Razmeri,Type,SupplierId,ImageName")] EditIzdlieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.EditSpalnq(model);
                return this.RedirectToAction("Spalni");
            }
            return this.RedirectToAction("EditSpalni");
        }

        [HttpGet]
        [Route("DeleteSpalni/{id}")]
        public ActionResult DeleteSpalni(int id)
        {
            DeleteProductViewModel model = this.service.GetDeleteSpalnqViewModel(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeleteSpalni/{id}")]
        public ActionResult DeleteSpalni([Bind(Include = "Id")] DeleteIzdelieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.DeleteSpalnq(model);
                return this.RedirectToAction("Spalni");
            }
            return this.RedirectToAction("DeleteSpalni");
        }


        //***************************************************************************************

        [Route("Detski")]
        public ActionResult Detski()
        {
            ICollection<ProductViewModel> models = this.service.GetDetskiViewMoedel();
            return View(models);
        }


        [HttpGet]
        [Route("CreateDetski")]
        public ActionResult CreateDetski()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CreateDetski")]
        public ActionResult CreateDetski(
            [Bind(Include = "CatNumber,Color,Description,Price,Name,Razmeri,Type,ImageName,NalichnostBr")] IzdeliqBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.AddDetski(model);
                return this.RedirectToAction("Detski");
            }
            return this.RedirectToAction("CreateDetski");

        }


        [HttpGet]
        [Route("EditDetski/{id}")]
        public ActionResult EditDetski(int id)
        {
            FullProductViewModel model = this.service.GetDetskaById(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditDetski/{id}")]
        public ActionResult EditDetski([Bind(Include = "Id,CatNumber,Color,Description,Price,Name,Razmeri,Type,SupplierId,ImageName")] EditIzdlieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.EditDetski(model);
                return this.RedirectToAction("Detski");
            }
            return this.RedirectToAction("EditDetski");
        }



        [HttpGet]
        [Route("DeleteDetski/{id}")]
        public ActionResult DeleteDetski(int id)
        {
            DeleteProductViewModel model = this.service.GetDeleteDetskaViewModel(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeleteDetski/{id}")]
        public ActionResult DeleteDetski([Bind(Include = "Id")] DeleteIzdelieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.DeleteDetski(model);
                return this.RedirectToAction("Detski");
            }
            return this.RedirectToAction("DeleteDetski");
        }

        //***************************************************************************************


        [Route("Sekcii")]
        public ActionResult Sekcii()
        {
            ICollection<ProductViewModel> models = this.service.GetSekciiViewMoedel();
            return View(models);
        }




        [HttpGet]
        [Route("CreateSekcii")]
        public ActionResult CreateSekcii()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CreateSekcii")]
        public ActionResult CreateSekcii(
            [Bind(Include = "CatNumber,Color,Description,Price,Name,Razmeri,Type,ImageName,NalichnostBr")] IzdeliqBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.AddSekcii(model);
                return this.RedirectToAction("Sekcii");
            }
            return this.RedirectToAction("CreateSekcii");

        }



        [HttpGet]
        [Route("EditSekcii/{id}")]
        public ActionResult EditSekcii(int id)
        {
            FullProductViewModel model = this.service.GetSekciqById(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditSekcii/{id}")]
        public ActionResult EditSekcii([Bind(Include = "Id,CatNumber,Color,Description,Price,Name,Razmeri,Type,SupplierId,ImageName")] EditIzdlieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.EditSekcii(model);
                return this.RedirectToAction("Sekcii");
            }
            return this.RedirectToAction("EditSekcii");
        }


        [HttpGet]
        [Route("DeleteSekcii/{id}")]
        public ActionResult DeleteSekcii(int id)
        {
            DeleteProductViewModel model = this.service.GetDeleteSekciqViewModel(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeleteSekcii/{id}")]
        public ActionResult DeleteSekcii([Bind(Include = "Id")] DeleteIzdelieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.DeleteSekcii(model);
                return this.RedirectToAction("Sekcii");
            }
            return this.RedirectToAction("DeleteSekcii");
        }


        //********************************************************************************************

        [Route("Portmanta")]
        public ActionResult Portmanta()
        {
            ICollection<ProductViewModel> models = this.service.GetPortmantaViewMoedel();
            return View(models);
        }




        [HttpGet]
        [Route("CreatePortmanta")]
        public ActionResult CreatePortmanta()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CreatePortmanta")]
        public ActionResult CreatePortmanta(
            [Bind(Include = "CatNumber,Color,Description,Price,Name,Razmeri,Type,ImageName,NalichnostBr")] IzdeliqBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.AddPortmanta(model);
                return this.RedirectToAction("Portmanta");
            }
            return this.RedirectToAction("CreatePortmanta");

        }



        [HttpGet]
        [Route("EditPortmanta/{id}")]
        public ActionResult EditPortmanta(int id)
        {
            FullProductViewModel model = this.service.GetPortmantoById(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditPortmanta/{id}")]
        public ActionResult EditPortmanta([Bind(Include = "Id,CatNumber,Color,Description,Price,Name,Razmeri,Type,SupplierId,ImageName")] EditIzdlieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.EditPortmanta(model);
                return this.RedirectToAction("Portmanta");
            }
            return this.RedirectToAction("EditPortmanta");
        }


        [HttpGet]
        [Route("DeletePortmanta/{id}")]
        public ActionResult DeletePortmanta(int id)
        {
            DeleteProductViewModel model = this.service.GetDeletePortmantoViewModel(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeletePortmanta/{id}")]
        public ActionResult DeletePortmanta([Bind(Include = "Id")] DeleteIzdelieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.DeletePortmanta(model);
                return this.RedirectToAction("Portmanta");
            }
            return this.RedirectToAction("DeletePortmanta");
        }


        //*********************************************************************************************************


        [Route("Kuhni")]
        public ActionResult Kuhni()
        {
            ICollection<ProductViewModel> models = this.service.GetKuhniViewMoedel();
            return View(models);
        }




        [HttpGet]
        [Route("CreateKuhni")]
        public ActionResult CreateKuhni()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CreateKuhni")]
        public ActionResult CreateKuhni(
            [Bind(Include = "CatNumber,Color,Description,Price,Name,Razmeri,Type,ImageName,NalichnostBr")] IzdeliqBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.AddKuhni(model);
                return this.RedirectToAction("Kuhni");
            }
            return this.RedirectToAction("CreateKuhni");

        }



        [HttpGet]
        [Route("EditKuhni/{id}")]
        public ActionResult EditKuhni(int id)
        {
            FullProductViewModel model = this.service.GetKuhnqById(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditKuhni/{id}")]
        public ActionResult EditKuhni([Bind(Include = "Id,CatNumber,Color,Description,Price,Name,Razmeri,Type,SupplierId,ImageName")] EditIzdlieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.EditKuhni(model);
                return this.RedirectToAction("Kuhni");
            }
            return this.RedirectToAction("EditKuhni");
        }


        [HttpGet]
        [Route("DeleteKuhni/{id}")]
        public ActionResult DeleteKuhni(int id)
        {
            DeleteProductViewModel model = this.service.GetDeleteKuhnqViewModel(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeleteKuhni/{id}")]
        public ActionResult DeleteKuhni([Bind(Include = "Id")] DeleteIzdelieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.DeleteKuhni(model);
                return this.RedirectToAction("Kuhni");
            }
            return this.RedirectToAction("DeleteKuhni");
        }

        //*****************************************************************************************************

        [Route("Masi")]
        public ActionResult Masi()
        {
            ICollection<ProductViewModel> models = this.service.GetMasiViewMoedel();
            return View(models);
        }




        [HttpGet]
        [Route("CreateMasi")]
        public ActionResult CreateMasi()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CreateMasi")]
        public ActionResult CreateMasi(
            [Bind(Include = "CatNumber,Color,Description,Price,Name,Razmeri,Type,ImageName,NalichnostBr")] IzdeliqBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.AddMasi(model);
                return this.RedirectToAction("Masi");
            }
            return this.RedirectToAction("CreateMasi");

        }



        [HttpGet]
        [Route("EditMasi/{id}")]
        public ActionResult EditMasi(int id)
        {
            FullProductViewModel model = this.service.GetMasaById(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditMasi/{id}")]
        public ActionResult EditMasi([Bind(Include = "Id,CatNumber,Color,Description,Price,Name,Razmeri,Type,SupplierId,ImageName")] EditIzdlieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.EditMasi(model);
                return this.RedirectToAction("Masi");
            }
            return this.RedirectToAction("EditMasi");
        }


        [HttpGet]
        [Route("DeleteMasi/{id}")]
        public ActionResult DeleteMasi(int id)
        {
            DeleteProductViewModel model = this.service.GetDeleteMasaViewModel(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeleteMasi/{id}")]
        public ActionResult DeleteMasi([Bind(Include = "Id")] DeleteIzdelieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.DeleteMasi(model);
                return this.RedirectToAction("Masi");
            }
            return this.RedirectToAction("DeleteMasi");
        }


//*********************************************************************************************************

        [HttpGet]
        public ActionResult GetSuppliers()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.PartialView(model);
        }

        [HttpGet]
        public ActionResult Suppliers()
        {
            ICollection<SuppliersViewModel> model = this.service.GetSuppliers();
            return this.View(model);
        }

        [HttpGet]
        public ActionResult CreateSupplier()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSupplier([Bind(Include = "Name, Telephone")]AddSupplierBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.AddSupplier(model);
                return this.RedirectToAction("Suppliers");
            }
            return this.RedirectToAction("CreateSupplier");
        }

        [HttpGet]
        [Route("EditSupplier/{id}")]
        public ActionResult EditSupplier(int id)
        {
            EditSupplierViewModel model = this.service.EditSupplier(id);
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditSupplier/{id}")]
        public ActionResult EditSupplier([Bind(Include = "Id,Name, Telephone")] EditSupplierBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.SaveEditSupplier(model);
                return this.RedirectToAction("Suppliers");
            }
            return this.RedirectToAction("EditSupplier");
        }

        [HttpGet]
        [Route("DeleteSupplier/{id}")]
        public ActionResult DeleteSupplier(int id)
        {

            SuppliersViewModel model = this.service.GetDeleteSuppliersViewModel(id);
            return this.View(model);
        }

        [HttpPost]
        [Route("DeleteSupplier/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSupplier([Bind(Include = "Id")] DeleteSupplierBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.DeleteSupplier(model);
                return this.RedirectToAction("Suppliers");
            }
            return this.RedirectToAction("DeleteSupplier");
        }

        [HttpGet]
        [Route("Porachki")]
        public ActionResult Porachki(int page=1,int pageSize=3)
        {
            ICollection<PorachkaViewModel> model = this.service.GetPorachkiViewMoedel();
            PagedList<PorachkaViewModel> models = new PagedList<PorachkaViewModel>(model, page, pageSize);
            return View(models);
        }

        [HttpGet]
        [Route("FinishPorachka/{id}")]
        public ActionResult FinishPorachka(int id)
        {
            PorachkaViewModel porachka = this.service.GetPorackaFinish(id);
            return this.View(porachka);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("FinishPorachka/{id}")]
        public ActionResult FinishPorachka([Bind(Include = "Id,IsActive")] PorachkaFinishBindingModel model)
        {

            if (ModelState.IsValid)
            {
                this.service.FinishPorachka(model);
                return this.RedirectToAction("Porachki");
            }
            return this.RedirectToAction("FinishPorachka");

        }

    }
}