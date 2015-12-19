using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCCI.Startup))]
namespace TCCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
