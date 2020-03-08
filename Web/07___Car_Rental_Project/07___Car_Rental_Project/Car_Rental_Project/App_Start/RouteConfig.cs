using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Car_Rental_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // if we want to have custom route we do it as it is show below, 
            //routes.MapRoute(
            //    "ItemsByReleaseDate",
            //    "items/published/{year}/{month}/{day}",
            //    new { controller = "Items", action = "ByDateOfPublish" },
            //    new { year = "\\d{4}", month = "\\d{2}" });

            // the better way is to have Attribute Route
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
