using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    public class ArticuloAutor
    {
        public int ArticuloID { get; set; }
        public int AutorID { get; set; }

        [Display(Name = "Orden")]
        public int OrdenAutor { get; set; }

        [Display(Name = "Autor Principal")]
        public bool EsAutorPrincipal { get; set; }

        [ForeignKey("ArticuloID")]
        public virtual Articulo Articulo { get; set; }

        [ForeignKey("AutorID")]
        public virtual Autor Autor { get; set; }
    }
}
