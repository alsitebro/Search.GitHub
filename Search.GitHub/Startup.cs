using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Search.GitHub.Startup))]
namespace Search.GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
