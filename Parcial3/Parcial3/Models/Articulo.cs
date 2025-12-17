using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    public class Articulo
    {
        [Key]
        public int ArticuloID { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(500)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Resumen")]
        public string Resumen { get; set; }

        [Display(Name = "Fecha de Publicación")]
        [DataType(DataType.Date)]
        public DateTime? FechaPublicacion { get; set; }

        [StringLength(200)]
        public string DOI { get; set; }

        [Display(Name = "Palabras Clave")]
        [StringLength(500)]
        public string Palabras_Clave { get; set; }

        [Display(Name = "Tipo de Documento")]
        [StringLength(100)]
        public string TipoDocumento { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [Display(Name = "Ubicación Física")]
        [StringLength(300)]
        public string UbicacionFisica { get; set; }

        [Display(Name = "Archivo Digital")]
        [StringLength(500)]
        public string ArchivoDigital { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public int? RevistaID { get; set; }
        [StringLength(20)]
        public string Volumen { get; set; }
        [StringLength(20)]
        public string Numero { get; set; }
        [StringLength(50)]
        public string Paginas { get; set; }

        [ForeignKey("RevistaID")]
        public virtual Revista Revista { get; set; }
        public virtual ICollection<ArticuloAutor> ArticuloAutores { get; set; }
        public virtual ICollection<ArticuloLinea> ArticuloLineas { get; set; }
        public virtual ICollection<Informe> Informes { get; set; }
    }
}
