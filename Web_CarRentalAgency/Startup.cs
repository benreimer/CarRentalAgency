using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_CarRentalAgency.Startup))]
namespace Web_CarRentalAgency
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
