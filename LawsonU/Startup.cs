using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LawsonU.Startup))]
namespace LawsonU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
