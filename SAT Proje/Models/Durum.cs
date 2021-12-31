using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAT_Proje.Models
{
    public class Durum
    {
        [Key]
        public int DurumId { get; set; }
        public int UrunSayısı { get; set; }
        public int MusterıSayısı { get; set; }

        Context x = new Context();
        public Durum GetModelState()
        {
            Durum drm = new Durum();
            Musterı mus = new Musterı();
            Urun urn = new Urun();
            drm.MusterıSayısı = x.Musterı.Count();
            drm.UrunSayısı = x.Uruns.Count();

            return drm;
        }
    }
}
