using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1 - produtos de todas as categorias
            routes.MapRoute(null,"", new { controller = "Vitrine",  Action = "ListaProdutos", categoria = (string) null, pagina = 1});

            // 2 - Todas as categorias por pagina
            routes.MapRoute(null,"Pagina{pagina}", new { controller = "Vitrine", Action = "ListaProdutos", categoria = (string) null }, new { pagina = @"\d+"});

            // 3 - primeira pagina da categoria selecionada
            routes.MapRoute(null,
               "{categoria}",
               new { controller = "Vitrine", Action = "ListaProdutos", pagina = 1 });

            // 4 - paginas da categoria selecionada
            routes.MapRoute(null,
               "{categoria}/Pagina{pagina}",
               new { controller = "Vitrine", Action = "ListaProdutos" }, new { pagina = @"\d+" });

            routes.MapRoute(null, "{controller}/{action}");


           /* routes.MapRoute(            
                name:null,
                url: "Pagina{pagina}",
                defaults: new { controller = "Vitrine", action = "ListaProdutos" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}
