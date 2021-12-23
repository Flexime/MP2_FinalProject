using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MP2_FinalProject.Startup))]
namespace MP2_FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
