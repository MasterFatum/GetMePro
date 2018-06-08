using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetMePro.Startup))]
namespace GetMePro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
