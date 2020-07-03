using System.ComponentModel.DataAnnotations;

namespace SishFae.Models
{
    public class Areas
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string NombreArea { get; set; }

        [Required]
        [Range(1, 2)]
        public int Estado { get; set; }

    }
}