using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Senhas_teste.Startup))]
namespace Senhas_teste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
