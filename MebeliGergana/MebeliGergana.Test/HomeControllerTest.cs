using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebeliGergana.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.FluentMVCTesting;

namespace MebeliGergana.Test
{
    [TestClass]
   public class HomeControllerTest
    {

        private HomeController controller;

        public HomeControllerTest()
        {
            this.controller=new HomeController();
        }

        [TestMethod]
        public void Index_ShouldPass()
        {
           
           this.controller.WithCallTo(h => h.Index()).ShouldRenderDefaultView();
            

        }

        [TestMethod]
        public void About_ShouldPass()
        {
            
            this.controller.WithCallTo(h => h.About()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void Contact()
        {
            this.controller.WithCallTo(h => h.Contact()).ShouldRenderDefaultView();
        }
    }
}
