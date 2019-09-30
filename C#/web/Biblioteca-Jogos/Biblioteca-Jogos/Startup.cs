using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biblioteca_Jogos.Startup))]
namespace Biblioteca_Jogos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
