using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Points.Application.Exceptions;

namespace Points.Presentation.Middlewares
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception exception)
            {
                httpContext.Response.ContentType = "text/html; charset=utf-8";
                httpContext.Response.StatusCode = exception switch
                {
                    NotFoundException => StatusCodes.Status404NotFound,
                    _ => StatusCodes.Status500InternalServerError
                };
                
                var response = new
                {
                    error = new
                    {
                        message = exception.Message
                    }
                };
                await httpContext.Response.WriteAsJsonAsync(response);
            }
        }
    }
}