using Microsoft.Owin;

public static class AppBuilderExtentions

{
    public static IAppBuilder Get(IAppBuilder appBuilder, string path, Func<IOwinContext,Func<Task>,Task> handler)

    {

        return appBuilder.Use((context, next) =>

            {
                if (context.Request.Method == "GET")

                {
                    return handler(context, next);
                }

                return next();

            });

    }

}
