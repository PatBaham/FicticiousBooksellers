using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FictitiousBookSeller.Startup))]
namespace FictitiousBookSeller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
