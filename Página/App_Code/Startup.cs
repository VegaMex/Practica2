using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Página.Startup))]
namespace Página
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
