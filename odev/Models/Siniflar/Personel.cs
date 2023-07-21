using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace odev.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Display(Name ="Personel Adı Girin:")]
        public string PersonelAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Display(Name = "Personel Soyadı Girin:")]
        public string PersonelSoyad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        [Display(Name = "Personel Görsel:")]
        public string PersonelGorsel { get; set; }
        public int Departmanid { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public virtual Departman Departman { get; set; }

    }
}