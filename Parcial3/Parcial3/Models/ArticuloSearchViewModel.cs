namespace Parcial3.Models
{
    public class ArticuloSearchViewModel
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string PalabraClave { get; set; }
        public int? RevistaID { get; set; }
        public int? LineaID { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string TipoDocumento { get; set; }
        public string Estado { get; set; }

        public List<Articulo> Resultados { get; set; }
    }

}
