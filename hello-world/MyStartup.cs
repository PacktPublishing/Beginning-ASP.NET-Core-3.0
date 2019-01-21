using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public class MyStartup
{
    public void Configure (IApplicationBuilder app)
    {
        app.Run(async context => {
            await context.Response.WriteAsync("Hello, World");
        });
    }
}