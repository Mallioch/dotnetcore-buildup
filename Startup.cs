using Microsoft.AspNetCore.Builder; //For IApplicationBuilder
using Microsoft.AspNetCore.Http;    //For Response.WriteAsync
using Microsoft.Extensions.DependencyInjection; //For IServiceCollection

public class Startup
{
    //Setup dependencies for injection here
    public void ConfigureServices(IServiceCollection services)
    {
        //Nothing yet!
    }

    //Configure your middleware pipeline
    public void Configure(IApplicationBuilder app)
    {
        app.UseStaticFiles();

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    }
}