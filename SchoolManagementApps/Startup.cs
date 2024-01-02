using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoolManagementApps.Startup))]
namespace ShoolManagementApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
