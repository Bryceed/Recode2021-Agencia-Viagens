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
    public class SuportesController : Controller
    {
        private readonly AppDatabaseContext _context;

        public SuportesController(AppDatabaseContext context)
        {
            _context = context;
        }

        // GET: Suportes
        public async Task<IActionResult> Index()
        {
            var appDatabaseContext = _context.Suporte.Include(s => s.Compras);
            return View(await appDatabaseContext.ToListAsync());
        }

        // GET: Suportes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte
                .Include(s => s.Compras)
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (suporte == null)
            {
                return NotFound();
            }

            return View(suporte);
        }

        // GET: Suportes/Create
        public IActionResult Create()
        {
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID");
            return View();
        }

        // POST: Suportes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketID,name,email,motivo,mensagem,SecID")] Suporte suporte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suporte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID", suporte.SecID);
            return View(suporte);
        }

        // GET: Suportes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte.FindAsync(id);
            if (suporte == null)
            {
                return NotFound();
            }
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID", suporte.SecID);
            return View(suporte);
        }

        // POST: Suportes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketID,name,email,motivo,mensagem,SecID")] Suporte suporte)
        {
            if (id != suporte.TicketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suporte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuporteExists(suporte.TicketID))
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
            ViewData["SecID"] = new SelectList(_context.dbBuyList, "SecID", "SecID", suporte.SecID);
            return View(suporte);
        }

        // GET: Suportes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte
                .Include(s => s.Compras)
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (suporte == null)
            {
                return NotFound();
            }

            return View(suporte);
        }

        // POST: Suportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suporte = await _context.Suporte.FindAsync(id);
            _context.Suporte.Remove(suporte);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuporteExists(int id)
        {
            return _context.Suporte.Any(e => e.TicketID == id);
        }
    }
}
