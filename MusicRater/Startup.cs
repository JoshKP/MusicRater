using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicRater.Startup))]
namespace MusicRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
