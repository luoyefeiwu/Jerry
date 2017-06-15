using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoFacDemo.Startup))]
namespace AutoFacDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
