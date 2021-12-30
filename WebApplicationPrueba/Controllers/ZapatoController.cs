using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplicacionPrueba.Models;
using WebApplicationPrueba.Data;

namespace WebApplicationPrueba.Controllers
{
    public class ZapatoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZapatoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Zapato
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zapatos.ToListAsync());
        }

        // GET: Zapato/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zapato = await _context.Zapatos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zapato == null)
            {
                return NotFound();
            }

            return View(zapato);
        }

        // GET: Zapato/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zapato/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo,Color,Talle,Tipo,Imagen,Descripcion,Precio,Stock")] Zapato zapato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zapato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zapato);
        }

        // GET: Zapato/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zapato = await _context.Zapatos.FindAsync(id);
            if (zapato == null)
            {
                return NotFound();
            }
            return View(zapato);
        }

        // POST: Zapato/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo,Color,Talle,Tipo,Imagen,Descripcion,Precio,Stock")] Zapato zapato)
        {
            if (id != zapato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zapato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZapatoExists(zapato.Id))
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
            return View(zapato);
        }

        // GET: Zapato/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zapato = await _context.Zapatos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zapato == null)
            {
                return NotFound();
            }

            return View(zapato);
        }

        // POST: Zapato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zapato = await _context.Zapatos.FindAsync(id);
            _context.Zapatos.Remove(zapato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZapatoExists(int id)
        {
            return _context.Zapatos.Any(e => e.Id == id);
        }
    }
}
