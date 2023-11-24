using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBanHaiSan.Startup))]
namespace WebBanHaiSan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
