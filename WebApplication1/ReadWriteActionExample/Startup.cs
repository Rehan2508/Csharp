using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadWriteActionExample.Startup))]
namespace ReadWriteActionExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
