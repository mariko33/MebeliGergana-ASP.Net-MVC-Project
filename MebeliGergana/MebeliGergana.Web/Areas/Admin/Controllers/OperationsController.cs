using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MebeliGergana.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OperationsController : Controller
    {
        // GET: Admin/Operation
        public ActionResult Index()
        {
            return View();
        }
    }
}