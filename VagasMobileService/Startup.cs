using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(VagasMobileService.Startup))]

namespace VagasMobileService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}