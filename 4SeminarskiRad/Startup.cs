using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4SeminarskiRad.Startup))]
namespace _4SeminarskiRad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
