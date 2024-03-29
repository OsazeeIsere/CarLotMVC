﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarLotMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("About", "About/{*pathinfo}", new { Controller = "Home", Action = "About" });
            routes.MapRoute("Contact", "Contact/{*pathinfo}", new { Controller = "Home", Action = "Contact" });
           // routes.MapRoute("Inventory", "Inventory/{*pathinfo}", new { Controller = "Inventory", Action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
