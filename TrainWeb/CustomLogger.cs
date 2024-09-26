using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace TrainWeb
{
    public class CustomLogger
    {
        private RequestDelegate _next;

        public CustomLogger(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.WriteAsync("I am useing CustomLogger ...\n");
            return _next(context);
        }
    }

    public static class CustomLogerExtension
    {
        public static IApplicationBuilder UseCustomLogger(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomLogger>();
        }
    }
}
