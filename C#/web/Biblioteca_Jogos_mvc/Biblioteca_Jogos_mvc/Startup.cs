using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biblioteca_Jogos_mvc.Startup))]
namespace Biblioteca_Jogos_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
