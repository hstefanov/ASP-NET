using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstAspNetWebForms.Startup))]
namespace MyFirstAspNetWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
