using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parcial3.Data;
using Parcial3.Models;
using Parcial3.Data;
using Parcial3.Models;

namespace Parcial3.Controllers
{
    public class ArticulosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticulosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var articulos = await _context.EC_Articulos
                .Include(a => a.Revista)
                .Include(a => a.ArticuloAutores)
                    .ThenInclude(aa => aa.Autor)
                .Include(a => a.ArticuloLineas)
                    .ThenInclude(al => al.LineaInvestigacion)
                .OrderByDescending(a => a.FechaRegistro)
                .ToListAsync();

            return View(articulos);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.EC_Articulos
                .Include(a => a.Revista)
                .Include(a => a.ArticuloAutores)
                    .ThenInclude(aa => aa.Autor)
                .Include(a => a.ArticuloLineas)
                    .ThenInclude(al => al.LineaInvestigacion)
                .Include(a => a.Informes)
                .FirstOrDefaultAsync(m => m.ArticuloID == id);

            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        public IActionResult Create()
        {
            ViewBag.Revistas = new SelectList(_context.EC_Revistas, "RevistaID", "NombreRevista");
            ViewBag.Autores = _context.EC_Autores.ToList();
            ViewBag.Lineas = _context.EC_LineasInvestigacion.Where(l => l.Activa).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Articulo articulo, int[] autoresSeleccionados, int[] lineasSeleccionadas)
        {
            if (ModelState.IsValid)
            {
                articulo.FechaRegistro = DateTime.Now;
                _context.Add(articulo);
                await _context.SaveChangesAsync();

                if (autoresSeleccionados != null)
                {
                    for (int i = 0; i < autoresSeleccionados.Length; i++)
                    {
                        var articuloAutor = new ArticuloAutor
                        {
                            ArticuloID = articulo.ArticuloID,
                            AutorID = autoresSeleccionados[i],
                            OrdenAutor = i + 1,
                            EsAutorPrincipal = (i == 0)
                        };
                        _context.EC_Articulos_Autores.Add(articuloAutor);
                    }
                }

                if (lineasSeleccionadas != null)
                {
                    foreach (var lineaId in lineasSeleccionadas)
                    {
                        var articuloLinea = new ArticuloLinea
                        {
                            ArticuloID = articulo.ArticuloID,
                            LineaID = lineaId
                        };
                        _context.EC_Articulos_Lineas.Add(articuloLinea);
                    }
                }

                await _context.SaveChangesAsync();
                TempData["Success"] = "Artículo registrado exitosamente.";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Revistas = new SelectList(_context.EC_Revistas, "RevistaID", "NombreRevista", articulo.RevistaID);
            ViewBag.Autores = _context.EC_Autores.ToList();
            ViewBag.Lineas = _context.EC_LineasInvestigacion.Where(l => l.Activa).ToList();
            return View(articulo);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.EC_Articulos
                .Include(a => a.ArticuloAutores)
                .Include(a => a.ArticuloLineas)
                .FirstOrDefaultAsync(a => a.ArticuloID == id);

            if (articulo == null)
            {
                return NotFound();
            }

            ViewBag.Revistas = new SelectList(_context.EC_Revistas, "RevistaID", "NombreRevista", articulo.RevistaID);
            ViewBag.Autores = _context.EC_Autores.ToList();
            ViewBag.Lineas = _context.EC_LineasInvestigacion.Where(l => l.Activa).ToList();
            ViewBag.AutoresActuales = articulo.ArticuloAutores.Select(aa => aa.AutorID).ToArray();
            ViewBag.LineasActuales = articulo.ArticuloLineas.Select(al => al.LineaID).ToArray();

            return View(articulo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Articulo articulo, int[] autoresSeleccionados, int[] lineasSeleccionadas)
        {
            if (id != articulo.ArticuloID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articulo);

                    var autoresExistentes = _context.EC_Articulos_Autores
                        .Where(aa => aa.ArticuloID == id);
                    _context.EC_Articulos_Autores.RemoveRange(autoresExistentes);

                    if (autoresSeleccionados != null)
                    {
                        for (int i = 0; i < autoresSeleccionados.Length; i++)
                        {
                            var articuloAutor = new ArticuloAutor
                            {
                                ArticuloID = id,
                                AutorID = autoresSeleccionados[i],
                                OrdenAutor = i + 1,
                                EsAutorPrincipal = (i == 0)
                            };
                            _context.EC_Articulos_Autores.Add(articuloAutor);
                        }
                    }

                    var lineasExistentes = _context.EC_Articulos_Lineas
                        .Where(al => al.ArticuloID == id);
                    _context.EC_Articulos_Lineas.RemoveRange(lineasExistentes);

                    if (lineasSeleccionadas != null)
                    {
                        foreach (var lineaId in lineasSeleccionadas)
                        {
                            var articuloLinea = new ArticuloLinea
                            {
                                ArticuloID = id,
                                LineaID = lineaId
                            };
                            _context.EC_Articulos_Lineas.Add(articuloLinea);
                        }
                    }

                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Artículo actualizado exitosamente.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticuloExists(articulo.ArticuloID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Revistas = new SelectList(_context.EC_Revistas, "RevistaID", "NombreRevista", articulo.RevistaID);
            ViewBag.Autores = _context.EC_Autores.ToList();
            ViewBag.Lineas = _context.EC_LineasInvestigacion.Where(l => l.Activa).ToList();
            return View(articulo);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.EC_Articulos
                .Include(a => a.Revista)
                .Include(a => a.ArticuloAutores)
                    .ThenInclude(aa => aa.Autor)
                .FirstOrDefaultAsync(m => m.ArticuloID == id);

            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var articulo = await _context.EC_Articulos.FindAsync(id);
            if (articulo != null)
            {
                _context.EC_Articulos.Remove(articulo);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Artículo eliminado exitosamente.";
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Search()
        {
            ViewBag.Revistas = new SelectList(_context.EC_Revistas, "RevistaID", "NombreRevista");
            ViewBag.Lineas = new SelectList(_context.EC_LineasInvestigacion.Where(l => l.Activa), "LineaID", "NombreLinea");
            return View(new ArticuloSearchViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Search(ArticuloSearchViewModel model)
        {
            var query = _context.EC_Articulos
                .Include(a => a.Revista)
                .Include(a => a.ArticuloAutores)
                    .ThenInclude(aa => aa.Autor)
                .Include(a => a.ArticuloLineas)
                    .ThenInclude(al => al.LineaInvestigacion)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(model.Titulo))
            {
                query = query.Where(a => a.Titulo.Contains(model.Titulo));
            }

            if (!string.IsNullOrWhiteSpace(model.Autor))
            {
                query = query.Where(a => a.ArticuloAutores.Any(aa =>
                    aa.Autor.Nombre.Contains(model.Autor) ||
                    aa.Autor.Apellidos.Contains(model.Autor)));
            }

            if (!string.IsNullOrWhiteSpace(model.PalabraClave))
            {
                query = query.Where(a => a.Palabras_Clave.Contains(model.PalabraClave));
            }

            if (model.RevistaID.HasValue)
            {
                query = query.Where(a => a.RevistaID == model.RevistaID);
            }

            if (model.LineaID.HasValue)
            {
                query = query.Where(a => a.ArticuloLineas.Any(al => al.LineaID == model.LineaID));
            }

            if (model.FechaDesde.HasValue)
            {
                query = query.Where(a => a.FechaPublicacion >= model.FechaDesde);
            }

            if (model.FechaHasta.HasValue)
            {
                query = query.Where(a => a.FechaPublicacion <= model.FechaHasta);
            }

            if (!string.IsNullOrWhiteSpace(model.TipoDocumento))
            {
                query = query.Where(a => a.TipoDocumento == model.TipoDocumento);
            }

            if (!string.IsNullOrWhiteSpace(model.Estado))
            {
                query = query.Where(a => a.Estado == model.Estado);
            }

            model.Resultados = await query.OrderByDescending(a => a.FechaPublicacion).ToListAsync();

            ViewBag.Revistas = new SelectList(_context.EC_Revistas, "RevistaID", "NombreRevista");
            ViewBag.Lineas = new SelectList(_context.EC_LineasInvestigacion.Where(l => l.Activa), "LineaID", "NombreLinea");

            return View(model);
        }

        private bool ArticuloExists(int id)
        {
            return _context.EC_Articulos.Any(e => e.ArticuloID == id);
        }
    }
}
