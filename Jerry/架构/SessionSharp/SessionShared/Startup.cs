using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessionShared.Startup))]
namespace SessionShared
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
