using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanMiCay.Data;
using BanMiCay.Models;

namespace BanMiCay.Controllers
{
    public class CthoaDonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CthoaDonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CthoaDons
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CthoaDon.Include(c => c.MahdNavigation).Include(c => c.MamhNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CthoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cthoaDon = await _context.CthoaDon
                .Include(c => c.MahdNavigation)
                .Include(c => c.MamhNavigation)
                .FirstOrDefaultAsync(m => m.Macthd == id);
            if (cthoaDon == null)
            {
                return NotFound();
            }

            return View(cthoaDon);
        }

        // GET: CthoaDons/Create
        public IActionResult Create()
        {
            ViewData["Mahd"] = new SelectList(_context.HoaDon, "Mahd", "Mahd");
            ViewData["Mamh"] = new SelectList(_context.MatHang, "Mamh", "Ten");
            return View();
        }

        // POST: CthoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Macthd,Mahd,Mamh,Dongia,Soluong,Thanhtien")] CthoaDon cthoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cthoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Mahd"] = new SelectList(_context.HoaDon, "Mahd", "Mahd", cthoaDon.Mahd);
            ViewData["Mamh"] = new SelectList(_context.MatHang, "Mamh", "Ten", cthoaDon.Mamh);
            return View(cthoaDon);
        }

        // GET: CthoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cthoaDon = await _context.CthoaDon.FindAsync(id);
            if (cthoaDon == null)
            {
                return NotFound();
            }
            ViewData["Mahd"] = new SelectList(_context.HoaDon, "Mahd", "Mahd", cthoaDon.Mahd);
            ViewData["Mamh"] = new SelectList(_context.MatHang, "Mamh", "Ten", cthoaDon.Mamh);
            return View(cthoaDon);
        }

        // POST: CthoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Macthd,Mahd,Mamh,Dongia,Soluong,Thanhtien")] CthoaDon cthoaDon)
        {
            if (id != cthoaDon.Macthd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cthoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CthoaDonExists(cthoaDon.Macthd))
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
            ViewData["Mahd"] = new SelectList(_context.HoaDon, "Mahd", "Mahd", cthoaDon.Mahd);
            ViewData["Mamh"] = new SelectList(_context.MatHang, "Mamh", "Ten", cthoaDon.Mamh);
            return View(cthoaDon);
        }

        // GET: CthoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cthoaDon = await _context.CthoaDon
                .Include(c => c.MahdNavigation)
                .Include(c => c.MamhNavigation)
                .FirstOrDefaultAsync(m => m.Macthd == id);
            if (cthoaDon == null)
            {
                return NotFound();
            }

            return View(cthoaDon);
        }

        // POST: CthoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cthoaDon = await _context.CthoaDon.FindAsync(id);
            _context.CthoaDon.Remove(cthoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CthoaDonExists(int id)
        {
            return _context.CthoaDon.Any(e => e.Macthd == id);
        }
    }
}
