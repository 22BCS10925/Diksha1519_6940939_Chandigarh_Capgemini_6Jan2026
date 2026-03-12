using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models
{
    [Table("tblRequestLog")]
    public class RequestLog
    {
       
            public string Url { get; set; }

            public long ExecutionTime { get; set; }
        
    }
}
