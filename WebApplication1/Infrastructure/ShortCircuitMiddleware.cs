using System.Text;
namespace WebApplication1.Infrastructure;

public class ShortCircuitMiddleware
{
    private readonly RequestDelegate _nextDelegate;

    public ShortCircuitMiddleware(RequestDelegate next)
    {
        _nextDelegate = next;
    }
    public async Task Invoke(HttpContext httpContext)
    {
        if (httpContext.Request.Headers["User-Agent"].Any(h => h.ToLower().Contains("chrome")))
            httpContext.Response.StatusCode = 403;
        else
            await _nextDelegate.Invoke(httpContext);
    }
}