using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityExt.MVC.Startup))]
namespace IdentityExt.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
