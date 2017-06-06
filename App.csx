using Owin;
using Microsoft.Owin.Hosting;

class Startup
{
    public void Configuration(IAppBuilder app) 
    {
		 app.Map("/path1", config =>
            {
                config.Use((context, next) => context.Response.WriteAsync("Hello from Devbrat on path1"));
            });
          app.Map("/path2", config =>

            {
                config.Use((context, next) => context.Response.WriteAsync("Hello from Devbrat on path2"));
            });
    }
}

using (WebApp.Start<Startup>("http://localhost:3000/")){   
	Console.WriteLine("We are up and running");
	Console.ReadLine();
}

