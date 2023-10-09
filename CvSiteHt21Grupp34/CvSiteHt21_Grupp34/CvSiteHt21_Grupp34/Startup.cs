using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CvSiteHt21_Grupp34.Startup))]
namespace CvSiteHt21_Grupp34
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
