using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Opiskelijat.Startup))]
namespace Opiskelijat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
