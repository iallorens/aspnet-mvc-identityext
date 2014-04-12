using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityExt.Web.Startup))]
namespace IdentityExt.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
