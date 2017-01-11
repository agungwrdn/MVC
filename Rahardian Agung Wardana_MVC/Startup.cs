using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rahardian_Agung_Wardana_MVC.Startup))]
namespace Rahardian_Agung_Wardana_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
