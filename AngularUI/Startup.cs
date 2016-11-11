using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularUI.Startup))]
namespace AngularUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
