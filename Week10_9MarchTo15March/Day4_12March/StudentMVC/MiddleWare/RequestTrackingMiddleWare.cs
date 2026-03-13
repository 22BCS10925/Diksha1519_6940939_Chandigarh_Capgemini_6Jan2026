using StudentMVC.Services;
using System.Diagnostics;

public class RequestTrackingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IRequestLogService _logService;

    public RequestTrackingMiddleware(RequestDelegate next, IRequestLogService logService)
    {
        _next = next;
        _logService = logService;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();

        await _next(context);

        stopwatch.Stop();

        string url = context.Request.Path;

        long timeTaken = stopwatch.ElapsedMilliseconds;

        _logService.AddLog(url, timeTaken);
    }
}