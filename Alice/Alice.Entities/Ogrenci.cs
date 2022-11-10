using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace Alice.Entities
{
    public class Ogrenci
    {
        public int ID { get; set; }

        [StringLength(50), Column(TypeName = "varchar(50)"), Display(Name = "Ögrenci Adı"), Required(ErrorMessage = "Ogrenci Adı Boş Geçilemez")]
        public string Ad { get; set; }
        [StringLength(50), Column(TypeName = "varchar(50)"), Display(Name = "Ögrenci Soyadı"), Required(ErrorMessage = "Ogrenci Soyadı Boş Geçilemez")]
        public string Soyad { get; set; }

        [StringLength(50), Column(TypeName = "varchar(50)"), Display(Name = "Ögrenci Numarası"), Required(ErrorMessage = "Ogrenci Numarası Boş Geçilemez")]
        public string OgrenciNo { get; set; }

        [StringLength(100), Column(TypeName = "varchar(100)")]
        public string Fakulte { get; set; }

        [StringLength(100), Column(TypeName = "varchar(100)")]
        public string Bolum { get; set; }
    }
}
