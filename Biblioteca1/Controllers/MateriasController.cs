
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteca1.Models;

public class MateriasController : Controller
{
    private readonly Biblioteca1Context _context;

    public MateriasController(Biblioteca1Context context)
    {
        _context = context;
    }

    // GET: MATERIAS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Materia.ToListAsync());
    }

    // GET: MATERIAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var materia = await _context.Materia
            .FirstOrDefaultAsync(m => m.ID == id);
        if (materia == null)
        {
            return NotFound();
        }

        return View(materia);
    }

    // GET: MATERIAS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: MATERIAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ID,Nombre,Nrc,Carrera,HorasSemanales")] Materia materia)
    {
        if (ModelState.IsValid)
        {
            _context.Add(materia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(materia);
    }

    // GET: MATERIAS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var materia = await _context.Materia.FindAsync(id);
        if (materia == null)
        {
            return NotFound();
        }
        return View(materia);
    }

    // POST: MATERIAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("ID,Nombre,Nrc,Carrera,HorasSemanales")] Materia materia)
    {
        if (id != materia.ID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(materia);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MateriaExists(materia.ID))
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
        return View(materia);
    }

    // GET: MATERIAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var materia = await _context.Materia
            .FirstOrDefaultAsync(m => m.ID == id);
        if (materia == null)
        {
            return NotFound();
        }

        return View(materia);
    }

    // POST: MATERIAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var materia = await _context.Materia.FindAsync(id);
        if (materia != null)
        {
            _context.Materia.Remove(materia);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool MateriaExists(int? id)
    {
        return _context.Materia.Any(e => e.ID == id);
    }
}
