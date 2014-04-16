using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamReviewProject.Startup))]
namespace ExamReviewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
