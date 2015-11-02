using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIA.Startup))]
namespace SIA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
