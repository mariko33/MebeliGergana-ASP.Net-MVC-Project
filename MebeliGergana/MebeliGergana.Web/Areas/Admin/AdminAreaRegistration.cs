using System.Web.Mvc;

namespace MebeliGergana.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.Routes.MapMvcAttributeRoutes();

            context.MapRoute(
               name: "Admin_default",
                url:"Admin/{controller}/{action}/{id}",
               defaults: new { action = "Index", id = UrlParameter.Optional, controller = "Operations" }
            );
        }
    }
}