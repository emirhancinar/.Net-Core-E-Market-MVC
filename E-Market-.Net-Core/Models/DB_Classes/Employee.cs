using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string Surname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Image { get; set; }
        public ICollection<Sales> Sales { get; set; }
        public Department Department { get; set; }
    }
}
