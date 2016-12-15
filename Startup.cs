using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M50TollCharges.Startup))]
namespace M50TollCharges
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
