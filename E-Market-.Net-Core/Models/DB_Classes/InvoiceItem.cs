using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class InvoiceItem
    {//Fatura Kalem
        [Key]
        public int InvoiceItemId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string About { get; set; }
        public int Piece { get; set; }//adet
        public decimal UnitPrice { get; set; }//birim fiyat
        public decimal Amount { get; set; }//miktar
        public Invoice Invoice { get; set; }





    }
}
