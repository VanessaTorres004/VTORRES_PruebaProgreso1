using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VTORRES_PruebaProgreso1.Data;
using VTORRES_PruebaProgreso1.Models;

namespace VTORRES_PruebaProgreso1.Controllers
{
    public class TorresController : Controller
    {
        private readonly VTORRES_PruebaProgreso1Context _context;

        public TorresController(VTORRES_PruebaProgreso1Context context)
        {
            _context = context;
        }

        // GET: Torres
        public async Task<IActionResult> Index()
        {
            var vTORRES_PruebaProgreso1Context = _context.Torres.Include(t => t.Celular);
            return View(await vTORRES_PruebaProgreso1Context.ToListAsync());
        }

        // GET: Torres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var torres = await _context.Torres
                .Include(t => t.Celular)
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (torres == null)
            {
                return NotFound();
            }

            return View(torres);
        }

        // GET: Torres/Create
        public IActionResult Create()
        {
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id");
            return View();
        }

        // POST: Torres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cedula,Salario,Nombre,Soltero,Nacimiento,CelularId")] Torres torres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(torres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id", torres.CelularId);
            return View(torres);
        }

        // GET: Torres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var torres = await _context.Torres.FindAsync(id);
            if (torres == null)
            {
                return NotFound();
            }
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id", torres.CelularId);
            return View(torres);
        }

        // POST: Torres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cedula,Salario,Nombre,Soltero,Nacimiento,CelularId")] Torres torres)
        {
            if (id != torres.Cedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(torres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TorresExists(torres.Cedula))
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
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id", torres.CelularId);
            return View(torres);
        }

        // GET: Torres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var torres = await _context.Torres
                .Include(t => t.Celular)
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (torres == null)
            {
                return NotFound();
            }

            return View(torres);
        }

        // POST: Torres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var torres = await _context.Torres.FindAsync(id);
            if (torres != null)
            {
                _context.Torres.Remove(torres);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TorresExists(int id)
        {
            return _context.Torres.Any(e => e.Cedula == id);
        }
    }
}
