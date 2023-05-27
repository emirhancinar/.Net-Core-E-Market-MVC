using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class Admin
    {
        public int AdminId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25)]
        public string UserName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Password { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1)]
        public string Authority { get; set; }//yetki
    }
}
