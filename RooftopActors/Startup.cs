using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RooftopActors.Startup))]
namespace RooftopActors
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
