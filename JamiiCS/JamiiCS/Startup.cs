using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JamiiCS.Startup))]
namespace JamiiCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
