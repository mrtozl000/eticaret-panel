﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace odev.Models.Siniflar
{
    public class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }

    }
}