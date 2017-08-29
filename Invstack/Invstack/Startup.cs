using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Invstack.Startup))]
namespace Invstack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
