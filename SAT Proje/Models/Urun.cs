using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAT_Proje.Models
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAdı { get; set; }
        public int UrunBarkod { get; set; }
        public int UrunFıyat { get; set; }
        public int UrunAdet { get; set; }
        public string UrunAcıklama { get; set; }



        //ilişkilendımek ıcın kullanır
        public List<Musterı> Musterıs { get; set; }
       
    }
}
