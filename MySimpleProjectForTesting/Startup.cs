using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySimpleProjectForTesting.Startup))]
namespace MySimpleProjectForTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
