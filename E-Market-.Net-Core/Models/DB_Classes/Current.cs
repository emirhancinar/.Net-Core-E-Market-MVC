using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Market_.Net_Core.Models.DB_Classes
{ 
    //Cari-->Current
    public class Current
    {
        [Key]
        public int CurrentId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string CurrentName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string CurrentSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string CurrentCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentMail { get; set; }
        public Sales Sales { get; set; }
    }
}
