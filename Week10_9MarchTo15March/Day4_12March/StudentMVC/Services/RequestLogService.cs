using StudentMVC.Models;
using StudentMVC.Services;

public class RequestLogService : IRequestLogService
{
    private readonly List<RequestLog> logs = new List<RequestLog>();

    public void AddLog(string url, long executionTime)
    {
        logs.Add(new RequestLog
        {
            Url = url,
            ExecutionTime = executionTime
        });
    }

    public List<RequestLog> GetLogs()
    {
        return logs;
    }
}