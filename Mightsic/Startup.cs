using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mightsic.Startup))]
namespace Mightsic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
