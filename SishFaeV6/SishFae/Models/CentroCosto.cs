using System.ComponentModel.DataAnnotations;

namespace SishFae.Models
{
    public class CentroCosto
    {

        public int Id { get; set; }

        [Required]
        public int UnidadNegocio { get; set; }

        [Required]
        public int CodCentroCosto { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string ClientePrimser { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Proyecto { get; set; }

        [Required]
        public int NHoras { get; set; }
    }
}