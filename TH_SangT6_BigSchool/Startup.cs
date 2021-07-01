using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TH_SangT6_BigSchool.Startup))]
namespace TH_SangT6_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
