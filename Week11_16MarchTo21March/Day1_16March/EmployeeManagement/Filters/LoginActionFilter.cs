using Microsoft.AspNetCore.Mvc.Filters;

public class LogActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        var action = context.ActionDescriptor.DisplayName;
        var time = DateTime.Now;

        Console.WriteLine($"Action: {action} executed at {time}");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
    }
}