using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDD_WebApp.Startup))]
namespace TDD_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
