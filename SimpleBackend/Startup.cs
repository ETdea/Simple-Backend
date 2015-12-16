using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SimpleBackend.Startup))]

namespace SimpleBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
