using System.ComponentModel.DataAnnotations;

namespace Parcial3.Models
{
    public class LineaInvestigacion
    {
        [Key]
        public int LineaID { get; set; }

        [Required(ErrorMessage = "El nombre de la línea es obligatorio")]
        [StringLength(200)]
        [Display(Name = "Nombre de la Línea")]
        public string NombreLinea { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public bool Activa { get; set; } = true;

        public virtual ICollection<ArticuloLinea> ArticuloLineas { get; set; }
    }
}
