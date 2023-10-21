using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pruebaoficial.Startup))]
namespace Pruebaoficial
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
