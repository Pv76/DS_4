using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    public class ArticuloLinea
    {
        public int ArticuloID { get; set; }
        public int LineaID { get; set; }

        [ForeignKey("ArticuloID")]
        public virtual Articulo Articulo { get; set; }

        [ForeignKey("LineaID")]
        public virtual LineaInvestigacion LineaInvestigacion { get; set; }
    }
}
