using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAT_Proje.Models
{
    public class Musterı
    {
        [Key]
        public int MusterıId { get; set; }
        public string MusterıAdıSoyadı { get; set; }
        public string MusterıAcıkAdres { get; set; }

        public string Musterıtel { get; set; }
        public string MusterıSehır { get; set; }
        public string SıparıDurum { get; set; }
       

        public int UrunId { get; set; }
        public Urun urun { get; set; }

       
    }
}
