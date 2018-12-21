using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITSProject.Startup))]
namespace ITSProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
