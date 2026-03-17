using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using WeeklyTestEmployee.Models;

namespace WeeklyTestEmployee.Models
{
    [Table("tableEmployeeProject")]
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public DateTime AssignedDate { get; set; }
    }
}