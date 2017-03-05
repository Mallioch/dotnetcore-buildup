using Microsoft.AspNetCore.Builder; //For IApplicationBuilder
using Microsoft.AspNetCore.Http;    //For Response.WriteAsync
using Microsoft.Extensions.DependencyInjection; //For IServiceCollection
using Microsoft.Extensions.Logging; //For ILoggerFactory

public class Startup
{
    //Setup dependencies for injection here
    public void ConfigureServices(IServiceCollection services)
    {
        //Nothing yet!
    }

    //Configure your middleware pipeline
    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        loggerFactory.AddConsole();

        app.UseMiddleware<ComeAtMeBroMiddleware>();
        app.UseStaticFiles();

        app.Run(async (context) =>
        {
            var logger = loggerFactory.CreateLogger("Pipeline End");
            logger.LogInformation("The end of the middleware pipeline");
            await context.Response.WriteAsync("Hello World!");
        });
    }
}