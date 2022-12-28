using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace API_Diagnostic
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы Web API
            // Настройка Web API для использования только проверки подлинности посредством маркера-носителя.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            //+ отключаем возможность вывода данных в формате xml
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //+ для отображения в json
            //config.Formatters.JsonFormatter.SupportedMediaTypes
            //.Add(new MediaTypeHeaderValue("text/json"));           

            // Маршруты Web API
            config.MapHttpAttributeRoutes();

          

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            

            //config.Routes.MapHttpRoute(
            //    name: "action",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //    );
        }
    }
}
