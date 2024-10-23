using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POS_Project.Startup))]
namespace POS_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
