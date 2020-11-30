using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RandevuSistemi.Models
{
    public class Kisiler
    {
        [Key]
        public int KisiId { get; set; }
        public string KisiAd { get; set; }
        public string KisiSoyad { get; set; }
        public string PoliceNo { get; set; }
        //[Display(Name = "Tc Kimlik"),
        //    Required(ErrorMessage = "Boş Geçilemez"),
        //   RegularExpression(@"(^[1 - 9]{1}[0-9]{9}[02468]{1}$)",
        //  ErrorMessage = "Lütfen Tc Kimlik No Formatına Uygun Giriniz.")]
        public string TcNo { get; set; }
        public String Tel { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public ICollection<Randevu> Randevus { get; set; }
    }
}