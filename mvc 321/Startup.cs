using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_321.Startup))]
namespace mvc_321
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
