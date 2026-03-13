using StudentMVC.Models;

namespace StudentMVC.Services
{
    public interface IRequestLogService
    {
        void AddLog(string url, long executionTime);

        List<RequestLog> GetLogs();
    }
}
