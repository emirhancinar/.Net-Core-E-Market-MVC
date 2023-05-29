using System.ComponentModel.DataAnnotations;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Sales
    {// Satış Hareket
        [Key]
        public int SalesId { get; set; }
        public DateTime Date { get; set; }
        public int Piece { get; set; }//adet
        public decimal Price { get; set; }//fiyat
        public decimal TotalAmount { get; set; } //toplam tutar
        public Product Producs { get; set; }
        public Current Current { get; set; }
        public Employee Employee { get; set; }    

    }
}
