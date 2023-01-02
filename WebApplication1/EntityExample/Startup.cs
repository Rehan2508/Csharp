using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityExample.Startup))]
namespace EntityExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
