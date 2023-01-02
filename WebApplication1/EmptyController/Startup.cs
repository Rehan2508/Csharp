using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmptyController.Startup))]
namespace EmptyController
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
