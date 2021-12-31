using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAT_Proje.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string Kullanıcı { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string Şifre { get; set; }


    }
}
