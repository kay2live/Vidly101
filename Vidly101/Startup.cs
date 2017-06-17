using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly101.Startup))]
namespace Vidly101
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
