using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamMinhPhuong_2011064727lab3.Startup))]
namespace PhamMinhPhuong_2011064727lab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
