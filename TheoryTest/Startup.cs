using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheoryTest.Startup))]
namespace TheoryTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
