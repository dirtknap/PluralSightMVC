using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluralSightMVC.Startup))]
namespace PluralSightMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
