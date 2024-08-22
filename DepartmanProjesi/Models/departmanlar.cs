using System.ComponentModel.DataAnnotations;

namespace DepartmanProjesi.Models
{
    public class departmanlar
    {
        [Key]
        public int id { get; set; }
        public string departmanad { get; set; }
    }
}
