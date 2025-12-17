using Microsoft.EntityFrameworkCore;
using Parcial3.Models;

namespace Parcial3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Articulo> EC_Articulos { get; set; }
        public DbSet<Autor> EC_Autores { get; set; }
        public DbSet<ArticuloAutor> EC_Articulos_Autores { get; set; }
        public DbSet<Revista> EC_Revistas { get; set; }
        public DbSet<Informe> EC_Informes { get; set; }
        public DbSet<LineaInvestigacion> EC_LineasInvestigacion { get; set; }
        public DbSet<ArticuloLinea> EC_Articulos_Lineas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ArticuloAutor>()
                .HasKey(aa => new { aa.ArticuloID, aa.AutorID });

            modelBuilder.Entity<ArticuloAutor>()
                .HasOne(aa => aa.Articulo)
                .WithMany(a => a.ArticuloAutores)
                .HasForeignKey(aa => aa.ArticuloID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ArticuloAutor>()
                .HasOne(aa => aa.Autor)
                .WithMany(a => a.ArticuloAutores)
                .HasForeignKey(aa => aa.AutorID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ArticuloLinea>()
                .HasKey(al => new { al.ArticuloID, al.LineaID });

            modelBuilder.Entity<ArticuloLinea>()
                .HasOne(al => al.Articulo)
                .WithMany(a => a.ArticuloLineas)
                .HasForeignKey(al => al.ArticuloID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ArticuloLinea>()
                .HasOne(al => al.LineaInvestigacion)
                .WithMany(l => l.ArticuloLineas)
                .HasForeignKey(al => al.LineaID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configurar precisión para decimales
            modelBuilder.Entity<Revista>()
                .Property(r => r.FactorImpacto)
                .HasPrecision(5, 3);
        }
    }
}
