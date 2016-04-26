using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Praksa_V2.Startup))]
namespace Praksa_V2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
