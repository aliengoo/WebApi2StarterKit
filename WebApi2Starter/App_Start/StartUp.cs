namespace WebApi2Starter
{
    using System.Web.Http;

    using Mcs;

    using Microsoft.AspNet.SignalR;
    using Microsoft.Owin.Cors;

    using Owin;

    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();

#if(DEBUG)
            GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
#else
			GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Never;
#endif

            // initialise mcs and unity before anything else - can cause model binding issues if you don't
            app.UseMcs(configuration, "test");
            app.UseUnity(configuration);

            configuration.SetRoutes();
            configuration.EnsureInitialized();

            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR(new HubConfiguration { EnableDetailedErrors = true });

            app.UseWebApi(configuration);
        }
    }
}