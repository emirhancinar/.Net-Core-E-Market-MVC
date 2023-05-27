using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set;}
    }
}
