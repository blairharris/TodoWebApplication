using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoWebApplication.Startup))]
namespace TodoWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
