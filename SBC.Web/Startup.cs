using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBC.Web.Startup))]
namespace SBC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
