using Microsoft.AspNetCore.Mvc.Filters;

namespace StudentManagementProject.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = context.ActionDescriptor.DisplayName;
            var time = DateTime.Now;

            Console.WriteLine($"Action Executing: {actionName} at {time}");
        }
    }
}