using Microsoft.Practices.Unity;
using MvcApplication1.Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ToDoListApplication.BusinessLayer.Repositories.Implementations;
using ToDoListApplication.BusinessLayer.Repositories.Interfaces;
using ToDoListApplication.BusinessLayer.Services;

namespace MvcApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<ITaskRepository, TaskRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPersonRepository, PersonRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITaskService, TaskService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPersonService, PersonService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            //config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
