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
    public class MathangsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MathangsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetInfo()
        {
            ViewBag.danhmuc = _context.DanhMuc.ToList();
        }

        // GET: Mathangs
        public async Task<IActionResult> Index()
        {
            GetInfo();
            var applicationDbContext = _context.MatHang.Include(m => m.MadmNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Mathangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            GetInfo();
            if (id == null)
            {
                return NotFound();
            }

            var mathang = await _context.MatHang
                .Include(m => m.MadmNavigation)
                .FirstOrDefaultAsync(m => m.Mamh == id);
            if (mathang == null)
            {
                return NotFound();
            }

            return View(mathang);
        }

        // GET: Mathangs/Create
        public IActionResult Create()
        {
            GetInfo();
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten");
            return View();
        }

        // POST: Mathangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mamh,Ten,Giagoc,Giaban,Soluong,Mota,Hinhanh,Madm,Luotxem,Luotmua")] MatHang mathang)
        {
            GetInfo();
            if (ModelState.IsValid)
            {
                _context.Add(mathang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", mathang.Madm);
            return View(mathang);
        }

        // GET: Mathangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            GetInfo();
            if (id == null)
            {
                return NotFound();
            }

            var mathang = await _context.MatHang.FindAsync(id);
            if (mathang == null)
            {
                return NotFound();
            }
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", mathang.Madm);
            return View(mathang);
        }

        // POST: Mathangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Mamh,Ten,Giagoc,Giaban,Soluong,Mota,Hinhanh,Madm,Luotxem,Luotmua")] MatHang mathang)
        {
            GetInfo();
            if (id != mathang.Mamh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mathang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MathangExists(mathang.Mamh))
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
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", mathang.Madm);
            return View(mathang);
        }

        // GET: Mathangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            GetInfo();
            if (id == null)
            {
                return NotFound();
            }

            var mathang = await _context.MatHang
                .Include(m => m.MadmNavigation)
                .FirstOrDefaultAsync(m => m.Mamh == id);
            if (mathang == null)
            {
                return NotFound();
            }

            return View(mathang);
        }

        // POST: Mathangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mathang = await _context.MatHang.FindAsync(id);
            _context.MatHang.Remove(mathang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MathangExists(int id)
        {
            return _context.MatHang.Any(e => e.Mamh == id);
        }
    }
}
