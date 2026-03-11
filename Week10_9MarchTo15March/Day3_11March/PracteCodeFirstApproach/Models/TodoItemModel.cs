using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PracteCodeFirstApproach.Models
{
    [Table("tblTodDo")]
    public class TodoItemModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isCompleted {  get; set; }

    }
}
