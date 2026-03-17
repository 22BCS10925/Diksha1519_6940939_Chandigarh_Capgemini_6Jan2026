
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeeklyTestEmployee.Models
{
    [Table("tableProject")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public List<EmployeeProject>? EmployeeProjects { get; set; }
    }
}
