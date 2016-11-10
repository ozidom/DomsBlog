using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DomsBlog.Startup))]
namespace DomsBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
