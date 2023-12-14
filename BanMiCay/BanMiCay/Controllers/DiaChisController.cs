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
    public class DiaChisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiaChisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DiaChis
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DiaChi.Include(d => d.MakhNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DiaChis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diaChi = await _context.DiaChi
                .Include(d => d.MakhNavigation)
                .FirstOrDefaultAsync(m => m.Madc == id);
            if (diaChi == null)
            {
                return NotFound();
            }

            return View(diaChi);
        }

        // GET: DiaChis/Create
        public IActionResult Create()
        {
            ViewData["Makh"] = new SelectList(_context.KhachHang, "Makh", "Dienthoai");
            return View();
        }

        // POST: DiaChis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Madc,Diachi1,Phuongxa,Quanhuyen,Tinhthanh,Makh,Macdinh,Daxoa")] DiaChi diaChi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diaChi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Makh"] = new SelectList(_context.KhachHang, "Makh", "Dienthoai", diaChi.Makh);
            return View(diaChi);
        }

        // GET: DiaChis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diaChi = await _context.DiaChi.FindAsync(id);
            if (diaChi == null)
            {
                return NotFound();
            }
            ViewData["Makh"] = new SelectList(_context.KhachHang, "Makh", "Dienthoai", diaChi.Makh);
            return View(diaChi);
        }

        // POST: DiaChis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Madc,Diachi1,Phuongxa,Quanhuyen,Tinhthanh,Makh,Macdinh,Daxoa")] DiaChi diaChi)
        {
            if (id != diaChi.Madc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diaChi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiaChiExists(diaChi.Madc))
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
            ViewData["Makh"] = new SelectList(_context.KhachHang, "Makh", "Dienthoai", diaChi.Makh);
            return View(diaChi);
        }

        // GET: DiaChis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diaChi = await _context.DiaChi
                .Include(d => d.MakhNavigation)
                .FirstOrDefaultAsync(m => m.Madc == id);
            if (diaChi == null)
            {
                return NotFound();
            }

            return View(diaChi);
        }

        // POST: DiaChis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diaChi = await _context.DiaChi.FindAsync(id);
            _context.DiaChi.Remove(diaChi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiaChiExists(int id)
        {
            return _context.DiaChi.Any(e => e.Madc == id);
        }
    }
}
