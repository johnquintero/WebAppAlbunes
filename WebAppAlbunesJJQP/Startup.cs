using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAlbunesJJQP.Startup))]
namespace WebAppAlbunesJJQP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
