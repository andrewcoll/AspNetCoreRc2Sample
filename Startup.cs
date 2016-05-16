using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace SampleRC2WebApp 
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (ctx) => 
            {
               await ctx.Response.WriteAsync("Hello World"); 
            });
        }
    }
}
