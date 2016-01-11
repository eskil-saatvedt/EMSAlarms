using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMSAlarms.Startup))]
namespace EMSAlarms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
