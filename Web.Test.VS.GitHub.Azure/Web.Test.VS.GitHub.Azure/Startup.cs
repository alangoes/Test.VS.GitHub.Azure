using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Test.VS.GitHub.Azure.Startup))]
namespace Web.Test.VS.GitHub.Azure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
