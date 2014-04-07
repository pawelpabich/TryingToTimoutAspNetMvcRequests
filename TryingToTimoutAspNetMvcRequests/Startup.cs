using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryingToTimoutAspNetMvcRequests.Startup))]
namespace TryingToTimoutAspNetMvcRequests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {           
        }
    }
}
