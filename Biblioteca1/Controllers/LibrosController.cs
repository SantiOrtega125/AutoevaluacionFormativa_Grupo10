
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteca1.Models;

public class LibrosController : Controller
{
    private readonly Biblioteca1Context _context;

    public LibrosController(Biblioteca1Context context)
    {
        _context = context;
    }

    // GET: LIBROS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Libro.ToListAsync());
    }

    // GET: LIBROS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _context.Libro
            .FirstOrDefaultAsync(m => m.ID == id);
        if (libro == null)
        {
            return NotFound();
        }

        return View(libro);
    }

    // GET: LIBROS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LIBROS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ID,Titulo,Autor,AnioPublicacion")] Libro libro)
    {
        if (ModelState.IsValid)
        {
            _context.Add(libro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(libro);
    }

    // GET: LIBROS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _context.Libro.FindAsync(id);
        if (libro == null)
        {
            return NotFound();
        }
        return View(libro);
    }

    // POST: LIBROS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("ID,Titulo,Autor,AnioPublicacion")] Libro libro)
    {
        if (id != libro.ID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(libro);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroExists(libro.ID))
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
        return View(libro);
    }

    // GET: LIBROS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _context.Libro
            .FirstOrDefaultAsync(m => m.ID == id);
        if (libro == null)
        {
            return NotFound();
        }

        return View(libro);
    }

    // POST: LIBROS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var libro = await _context.Libro.FindAsync(id);
        if (libro != null)
        {
            _context.Libro.Remove(libro);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LibroExists(int? id)
    {
        return _context.Libro.Any(e => e.ID == id);
    }
}
