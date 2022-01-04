#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WellN_M2_AgenciaViagens.Data;
using WellN_M2_AgenciaViagens.Models;

namespace WellN_M2_AgenciaViagens.Controllers
{
    public class PacotesController : Controller
    {
        private readonly AppDatabaseContext _context;

        public PacotesController(AppDatabaseContext context)
        {
            _context = context;
        }

        // GET: Pacotes
        public async Task<IActionResult> Index()
        {
            var appDatabaseContext = _context.dbPackages.Include(p => p.Compras);
            return View(await appDatabaseContext.ToListAsync());
        }

        // GET: Pacotes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacotes = await _context.dbPackages
                .Include(p => p.Compras)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pacotes == null)
            {
                return NotFound();
            }

            return View(pacotes);
        }

        // GET: Pacotes/Create
        public IActionResult Create()
        {
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID");
            return View();
        }

        // POST: Pacotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,preco,precoOriginal,destino,pessoasContempladas,hasOnibus,hasAviao,hasNavio,hasHotel,hasAlimentacao,SecID")] Pacotes pacotes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pacotes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID", pacotes.SecID);
            return View(pacotes);
        }

        // GET: Pacotes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacotes = await _context.dbPackages.FindAsync(id);
            if (pacotes == null)
            {
                return NotFound();
            }
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID", pacotes.SecID);
            return View(pacotes);
        }

        // POST: Pacotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,preco,precoOriginal,destino,pessoasContempladas,hasOnibus,hasAviao,hasNavio,hasHotel,hasAlimentacao,SecID")] Pacotes pacotes)
        {
            if (id != pacotes.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pacotes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacotesExists(pacotes.ID))
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
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID", pacotes.SecID);
            return View(pacotes);
        }

        // GET: Pacotes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacotes = await _context.dbPackages
                .Include(p => p.Compras)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pacotes == null)
            {
                return NotFound();
            }

            return View(pacotes);
        }

        // POST: Pacotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pacotes = await _context.dbPackages.FindAsync(id);
            _context.dbPackages.Remove(pacotes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacotesExists(int id)
        {
            return _context.dbPackages.Any(e => e.ID == id);
        }
    }
}
