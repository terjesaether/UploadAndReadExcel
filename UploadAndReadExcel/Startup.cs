using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UploadAndReadExcel.Startup))]
namespace UploadAndReadExcel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
