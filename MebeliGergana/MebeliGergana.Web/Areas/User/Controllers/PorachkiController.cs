using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels.User;
using MebeliGergana.Services;
using MebeliGergana.Services.Interfaces;
using MebeliGergana.Services.UserServices;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;


namespace MebeliGergana.Web.Areas.User.Controllers
{
    [Authorize(Roles = "User")]
    [RouteArea("User")]
    [RoutePrefix("Porachki")]
    public class PorachkiController : Controller
    {
        private IPorachkiServices service;

        
        public PorachkiController(IPorachkiServices service)
        {
            this.service = service;

        }

        //GET: User/Porachki
        
        [HttpGet]
        
        public ActionResult PorachkaClient()
        {
            string currentUserId = User.Identity.GetUserId();
            //if (!User.Identity.IsAuthenticated)
            //{
            //    return RedirectToAction("Login", "Account");
            //}
            //else
            //{
                CurrentUserViewModel currentUser = this.service.GetClient(currentUserId);

                return PartialView("_Client", currentUser);
           // }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult PorachkaClient(
            [Bind(Include = "SupplierId,Izdelie,IzdelieId,Type,Name,Color,Description,Price,Broi,ClientId,FirstName,LastName,Adress,PhoneNumber")]PorachkaBindingModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.SavePorachka(model);
                return this.RedirectToAction("Index", "Home", new {area=""});
            }

            return this.RedirectToAction("Details", "Izdeliq", new { area = "", id = model.IzdelieId, izdelie = model.Izdelie });

        }
    }
}