using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Expense
    {//Gider
        [Key]
        public int ExpenseId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string About { get; set;}
        public DateTime ExpenseDate { get; set; }
        public int Amount { get; set; }//tutar

    }
}
