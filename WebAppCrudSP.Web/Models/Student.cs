using System.ComponentModel.DataAnnotations;

namespace WebAppCrudSP.Web.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Edad { get; set; }
    }
}
