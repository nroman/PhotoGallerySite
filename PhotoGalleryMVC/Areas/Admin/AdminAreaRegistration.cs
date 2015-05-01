using System.Web.Mvc;

namespace PhotoGalleryMVC.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin",
                "Admin/{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Admin",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                namespaces: new[] { "PhotoGalleryMVC.Areas.Admin.Controllers" }
            );
        }
    }
}