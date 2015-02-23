using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jakubkaleta.com.Startup))]
namespace jakubkaleta.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
