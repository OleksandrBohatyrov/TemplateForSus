using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateForSus.Startup))]
namespace TemplateForSus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
