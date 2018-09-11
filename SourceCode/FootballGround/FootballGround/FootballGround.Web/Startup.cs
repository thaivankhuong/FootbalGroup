using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballGround.Web.Startup))]
namespace FootballGround.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
