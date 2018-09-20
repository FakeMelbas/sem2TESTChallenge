using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengeTESTWeb.Startup))]
namespace ChallengeTESTWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
