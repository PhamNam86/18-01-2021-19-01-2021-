using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ngay19012021.Startup))]
namespace Ngay19012021
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
