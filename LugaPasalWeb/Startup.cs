using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LugaPasalWeb.Startup))]
namespace LugaPasalWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
