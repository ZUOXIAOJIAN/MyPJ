using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPJ.Web.Startup))]
namespace MyPJ.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
