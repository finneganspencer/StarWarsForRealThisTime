using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarWarsWebsite.Startup))]
namespace StarWarsWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
