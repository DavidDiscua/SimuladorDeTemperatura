using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimuladorTemperatura.Startup))]
namespace SimuladorTemperatura
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
