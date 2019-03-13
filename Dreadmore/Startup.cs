using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dreadmore.Startup))]
namespace Dreadmore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
