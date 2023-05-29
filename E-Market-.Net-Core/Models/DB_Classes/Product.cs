using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string Brand { get; set; }//marka
        public short Stock { get; set; }//stok
        public decimal PurchasePrice { get; set; }//alış fiyatı
        public decimal SalePrice { get; set; }//satış fiyatı
        public bool State { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Image { get; set; }
        public Category Category { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
