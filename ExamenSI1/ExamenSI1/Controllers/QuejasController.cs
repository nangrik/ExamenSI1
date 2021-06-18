using ExamenSI1.Data;
using ExamenSI1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenSI1.Controllers
{
    public class QuejasController: Controller
    {
        private readonly ApplicationDbContext db;

        public QuejasController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index(string search)
        {
            if (search==null)
            {
                return View(await db.Quejas.ToListAsync());
            }
            return View(await db.Quejas.Where(d => d.QuejaNombre.Contains(search)).ToListAsync());
        }

        public async Task<IActionResult> Details (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Queja = await db.Quejas.FirstOrDefaultAsync(m => m.QuejaId == id);
            if (Queja == null)
            {
                return NotFound();
            }
            return View(Queja);
        }

        //Nueva Queja

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Queja queja)
        {
            if (ModelState.IsValid)
            {
                db.Add(queja);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(queja);
        }

        //Quejas edit
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var rec = await db.Quejas.FindAsync(Id);

            if (rec == null)
            {
                return NotFound();
            }
            return View(rec);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, Queja queja)
        {
            if (Id != queja.QuejaId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(queja);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(queja);
        }

        //Borrar Queja
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var queja = await db.Quejas.FirstOrDefaultAsync(m => m.QuejaId == id);
            if (queja == null)
            {
                return NotFound();
            }
            return View(queja);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var qjs = await db.Quejas.FindAsync(id);
            db.Quejas.Remove(qjs);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
