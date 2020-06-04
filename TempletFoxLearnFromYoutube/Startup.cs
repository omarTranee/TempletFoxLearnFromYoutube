using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TempletFoxLearnFromYoutube.Startup))]
namespace TempletFoxLearnFromYoutube
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
