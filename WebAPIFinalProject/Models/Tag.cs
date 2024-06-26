using System.ComponentModel.DataAnnotations;

namespace WebAPIFinalProject.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? DisplayNombre { get; set; }

    }
}
