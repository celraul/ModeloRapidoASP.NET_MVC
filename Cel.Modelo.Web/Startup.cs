using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cel.Modelo.web.Startup))]
namespace Cel.Modelo.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
