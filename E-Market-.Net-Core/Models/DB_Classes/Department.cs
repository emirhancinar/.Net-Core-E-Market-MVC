using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
