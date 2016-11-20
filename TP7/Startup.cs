using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP7.Startup))]
namespace TP7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
