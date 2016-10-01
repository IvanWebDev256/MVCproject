using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HomeIndex",
                url: "",
                defaults: new {controller = "Home", action = "Index"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET")}
            );

            //Restaurant routes
            routes.MapRoute(
                name: "RestaurantIndex",
                url: "restaurants",
                defaults: new {controller = "Restaurant", action = "Index"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET")}
            );

            routes.MapRoute(
                name: "RestaurantCreate",
                url: "restaurants/create",
                defaults: new {controller = "Restaurant", action = "Create"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET", "POST")}
            );

            routes.MapRoute(
                name: "RestaurantEdit",
                url: "restaurants/{id}/edit",
                defaults: new {controller = "Restaurant", action = "Edit"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET", "POST")}
            );

            routes.MapRoute(
                name: "RestaurantDelete",
                url: "restaurants/{id}/delete",
                defaults: new {controller = "Restaurant", action = "Delete"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET", "POST")}
            );

            //Review routes
            routes.MapRoute(
                name: "ReviewIndex",
                url: "restaurants/{restaurantId}/reviews",
                defaults: new { controller = "Review", action = "Index" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }  
            );

            routes.MapRoute(
                name: "ReviewCreate",
                url: "restaurants/{restaurantId}/reviews/create",
                defaults: new { controller = "Review", action = "Create" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET", "POST") }
            );

            routes.MapRoute(
                name: "ReviewEdit",
                url: "restaurants/{restaurantId}/reviews/{id}/edit",
                defaults: new { controller = "Review", action = "Edit" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET", "POST") }
            );

            routes.MapRoute(
                name: "ReviewDelete",
                url: "restaurants/{restaurantId}/reviews/{id}/delete",
                defaults: new { controller = "Review", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET", "POST") }
            );

        }
    }
}
