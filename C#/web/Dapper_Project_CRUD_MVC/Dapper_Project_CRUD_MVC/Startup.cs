using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dapper_Project_CRUD_MVC.Startup))]
namespace Dapper_Project_CRUD_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
