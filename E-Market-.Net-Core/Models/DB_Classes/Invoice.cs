using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Invoice
    {//Fatura
        [Key]
        public int InvoiceId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1)]
        public string SerialNumber { get; set;}

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string SequenceNumber{ get; set;}//Sıra numarası
        public DateTime InvoiceDate { get; set;} 

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set;}//vergi dairesi
        public DateTime Hours { get;}

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string Submitter { get; set;}//teslim eden

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string Receiver { get; set;}// teslim alan
        public ICollection<InvoiceItem> InvoiceItems { get; set;}

    }
}
