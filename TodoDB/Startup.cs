using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoDB.Startup))]
namespace TodoDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
