namespace WebApi2Starter
{
    using System.Web.Http;

    using Mcs.Repositories;

    using Microsoft.Practices.Unity;

    using MongoDB.Driver;

    using Owin;

    public static class UnityConfig
    {
        public static IUnityContainer UseUnity(this IAppBuilder app, HttpConfiguration configuration)
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            configuration.DependencyResolver = new CustomUnityDependencyResolver(container);
            app.Properties.Add("unity.container", container);

            // add mongodb csharp stuff into unity
            container.RegisterInstance(typeof(MongoDatabase), (app.Properties["mongodb.test"] as MongoDatabase));
            container.RegisterType<IMongoRepository, MongoRepository>();
         
            return container;
        }
    }
}