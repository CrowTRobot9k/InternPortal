using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternPortal.UI.Startup))]
namespace InternPortal.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
