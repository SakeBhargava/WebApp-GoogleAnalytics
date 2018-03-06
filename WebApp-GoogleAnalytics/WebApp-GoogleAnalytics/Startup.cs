using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_GoogleAnalytics.Startup))]
namespace WebApp_GoogleAnalytics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
