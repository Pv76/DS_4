using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [StringLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Institución")]
        [StringLength(200)]
        public string Institucion { get; set; }

        [StringLength(50)]
        public string ORCID { get; set; }

        [NotMapped]
        public string NombreCompleto => $"{Nombre} {Apellidos}";

        public virtual ICollection<ArticuloAutor> ArticuloAutores { get; set; }
    }

}
