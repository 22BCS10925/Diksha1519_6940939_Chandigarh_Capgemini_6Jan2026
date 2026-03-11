using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCDemoBook.Models
{
    [Table("tblBook")]
    public class BookModel
    {
 
        [Key]
        public int BookModelId { get; set; }

        public string BName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public string Title { get; set; }
        public string Author {  get; set; }
    }
}

