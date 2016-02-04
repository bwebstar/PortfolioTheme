using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortfolioTheme.Startup))]
namespace PortfolioTheme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
