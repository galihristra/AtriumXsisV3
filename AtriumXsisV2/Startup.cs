using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtriumXsisV2.Startup))]
namespace AtriumXsisV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
