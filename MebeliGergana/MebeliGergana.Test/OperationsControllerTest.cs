using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MebeliGergana.Web.Areas.Admin.Controllers;
using TestStack.FluentMVCTesting;

namespace MebeliGergana.Test
{
    [TestClass]
   public class OperationsControllerTest
    {
        private OperationsController controller;

        [TestInitialize]
        public void Init()
        {
            this.controller=new OperationsController();
        }

        [TestMethod]
        public void Index_ShouldPass()
        {
            this.controller.WithCallTo(h => h.Index()).ShouldRenderDefaultView();
        }
    }
}
