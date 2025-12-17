using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    public class Informe
    {
        [Key]
        public int InformeID { get; set; }

        public int ArticuloID { get; set; }

        [Display(Name = "Tipo de Informe")]
        [StringLength(100)]
        public string TipoInforme { get; set; }

        [Display(Name = "Número de Informe")]
        [StringLength(50)]
        public string NumeroInforme { get; set; }

        [Display(Name = "Fecha del Informe")]
        [DataType(DataType.Date)]
        public DateTime? FechaInforme { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Archivo Adjunto")]
        [StringLength(500)]
        public string ArchivoAdjunto { get; set; }

        [ForeignKey("ArticuloID")]
        public virtual Articulo Articulo { get; set; }
    }

}
