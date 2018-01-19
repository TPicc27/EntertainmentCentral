using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntertainmentCentral.Startup))]
namespace EntertainmentCentral
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
