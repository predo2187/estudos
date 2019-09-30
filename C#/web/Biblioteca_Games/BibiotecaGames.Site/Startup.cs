using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibiotecaGames.Site.Startup))]
namespace BibiotecaGames.Site
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
