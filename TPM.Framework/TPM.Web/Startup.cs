using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPM.Web.Startup))]
namespace TPM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
