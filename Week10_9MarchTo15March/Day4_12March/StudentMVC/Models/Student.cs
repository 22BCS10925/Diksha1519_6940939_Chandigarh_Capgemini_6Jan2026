using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models
{
    [Table("tblStudent")]
    public class Student
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string deptName {  get; set; }
        public int Age { get; set; }
    }
}
