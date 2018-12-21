using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DejtingSajt.Startup))]
namespace DejtingSajt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
