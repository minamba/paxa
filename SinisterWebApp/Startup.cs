using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinisterWebApp.Startup))]
namespace SinisterWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
