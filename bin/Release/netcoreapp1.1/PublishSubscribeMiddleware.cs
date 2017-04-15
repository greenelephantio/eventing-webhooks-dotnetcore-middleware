using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace GreenElephantIO.Middleware
{
    public class PublishSubscribeMiddleware
    {
        private readonly RequestDelegate _next;

        public PublishSubscribeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine($"invoked! blaaaaaa {httpContext.Request.Path}");

            return this._next(httpContext);
        }
    }
}
