using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project1SecondTry.Startup))]
namespace Project1SecondTry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
