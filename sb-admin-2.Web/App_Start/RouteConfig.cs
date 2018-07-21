using System.Web.Mvc;
using System.Web.Routing;

namespace sb_admin_2.Web
{
    //public class RouteConfig
    //{
    //    public static void RegisterRoutes(RouteCollection routes)
    //    {
    //        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

    //        routes.MapRoute(
    //            name: "Default",
    //            url: "{controller}/{action}/{id}",
    //            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
    //        );
    //    }
    //}

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // Better way of defining new routes. It's called attribute 
                                            //routing.

            // Not a good way of defining new routes
            /*routes.MapRoute(
                "VisitorsByDate",
                "visitors/visited/{year}/{month}",
                new { controller = "Visitors", action = "ByVisitedDate"});*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
