using System.ComponentModel.DataAnnotations;

namespace DepartmanProjesi.Models
{
    public class personel
    {
        [Key]
        public int personelid { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }
    }
}
