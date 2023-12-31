﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace odev.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int Urunid { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string UrunAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }
        public string UrunGorsel { get; set; }
        public int kategoriid { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }

    }
}