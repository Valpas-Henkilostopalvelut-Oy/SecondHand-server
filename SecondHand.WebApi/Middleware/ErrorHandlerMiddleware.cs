

using Microsoft.EntityFrameworkCore;

namespace SecondHand.WebApi.Middleware
{
    public class ErrorHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            // catch (AuthentificationException ex)
            // {
            //     context.Response.StatusCode = ex.StatusCode;
            //     await context.Response.WriteAsync(ex.ErrorMessage);
            // }
            catch (DbUpdateException)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync("Database error");
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync("Internal server error (custom)");
            }
        }
    }
}