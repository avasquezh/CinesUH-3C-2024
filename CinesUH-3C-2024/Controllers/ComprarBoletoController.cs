using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinesUH_3C_2024.Data;
using CinesUH_3C_2024.Models;

namespace CinesUH_3C_2024.Controllers
{
    public class ComprarBoletoController : Controller
    {
        private readonly CinesUH_3C_2024Context _context;

        public ComprarBoletoController(CinesUH_3C_2024Context context)
        {
            _context = context;
        }

        // GET: SalasUHs
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: SalasUHs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salasUH = await _context.SalasUH
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salasUH == null)
            {
                return NotFound();
            }

            return View(salasUH);
        }

        // GET: SalasUHs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalasUHs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sala,Pelicula,Horario")] SalasUH salasUH)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salasUH);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salasUH);
        }

        // GET: SalasUHs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salasUH = await _context.SalasUH.FindAsync(id);
            if (salasUH == null)
            {
                return NotFound();
            }
            return View(salasUH);
        }

        // POST: SalasUHs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sala,Pelicula,Horario")] SalasUH salasUH)
        {
            if (id != salasUH.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salasUH);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalasUHExists(salasUH.Id))
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
            return View(salasUH);
        }

        // GET: SalasUHs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salasUH = await _context.SalasUH
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salasUH == null)
            {
                return NotFound();
            }

            return View(salasUH);
        }

        // POST: SalasUHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salasUH = await _context.SalasUH.FindAsync(id);
            if (salasUH != null)
            {
                _context.SalasUH.Remove(salasUH);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalasUHExists(int id)
        {
            return _context.SalasUH.Any(e => e.Id == id);
        }
    }
}
