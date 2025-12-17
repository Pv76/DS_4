using System.ComponentModel.DataAnnotations;

namespace Parcial3.Models
{
    public class Revista
    {
        [Key]
        public int RevistaID { get; set; }

        [Required(ErrorMessage = "El nombre de la revista es obligatorio")]
        [StringLength(300)]
        [Display(Name = "Nombre de la Revista")]
        public string NombreRevista { get; set; }

        [StringLength(200)]
        public string Editorial { get; set; }

        [StringLength(20)]
        public string ISSN { get; set; }

        [Display(Name = "Factor de Impacto")]
        public decimal? FactorImpacto { get; set; }

        [StringLength(10)]
        public string Cuartil { get; set; }

        [StringLength(500)]
        public string URL { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
