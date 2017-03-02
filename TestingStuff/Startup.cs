using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingStuff.Startup))]
namespace TestingStuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
