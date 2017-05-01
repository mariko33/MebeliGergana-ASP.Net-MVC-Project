using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MebeliGergana.Web.Startup))]
namespace MebeliGergana.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
