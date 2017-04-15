using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenElephantIO.Middleware
{
    public static class PublishSubscribeMiddlewareExtension
    {
        public static IApplicationBuilder UsePublishSubscribeFunctionality(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<PublishSubscribeMiddleware>();
        }
    }
}
