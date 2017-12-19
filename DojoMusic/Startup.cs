using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DojoMusic.Startup))]
namespace DojoMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
