using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KillinItMathFactsV2.Startup))]
namespace KillinItMathFactsV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
