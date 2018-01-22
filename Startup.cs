using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(third.Startup))]
namespace third
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
