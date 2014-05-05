using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShipIt.Server.Web.Startup))]
namespace ShipIt.Server.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
