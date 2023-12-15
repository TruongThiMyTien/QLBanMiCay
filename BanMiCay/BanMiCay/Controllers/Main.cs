using BanMiCay.Data;
using BanMiCay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanMiCay.Controllers
{
    public class Main : Controller
    {
        private readonly ApplicationDbContext _context;

        public Main(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Thống kê theo ngày
        public IActionResult ThongKeTheoNgay()
        {
            return View();
        }

        [HttpPost]
        public IActionResult XemThongKeTheoNgay(DateTime Ngaybatdau, DateTime Ngayketthuc)
        {
            var lstHD = _context.HoaDon.Where(d => d.Ngay >= Ngaybatdau && d.Ngay <= Ngayketthuc && d.Trangthai == 1).Include(m => m.MakhNavigation);
            int tongtien = 0;
            foreach (HoaDon hd in lstHD)
            {
                tongtien += hd.Tongtien;
            }
            ViewData["ngaybatdau"] = Ngaybatdau.Month.ToString() + "/" + Ngaybatdau.Day.ToString() + "/" + Ngaybatdau.Year.ToString();
            ViewData["ngayketthuc"] = Ngayketthuc.Month.ToString() + "/" + Ngayketthuc.Day.ToString() + "/" + Ngayketthuc.Year.ToString();
            ViewData["tongtien"] = tongtien.ToString("n0");
            return View(lstHD);
        }

        public void GetInfo()
        {
            ViewBag.mathang = _context.MatHang.ToList();
        }

        // Thống kê theo mặt hàng
        public IActionResult ThongKeTheoMatHang()
        {
            GetInfo();
            return View();
        }

        [HttpPost]
        public IActionResult XemThongKeTheoMatHang(int id)
        {
            var lstctHD = _context.CthoaDon.Where(j => j.Mamh == id).Include(m => m.MamhNavigation);
            int tongtien = 0;
            foreach (CthoaDon cthd in lstctHD)
            {
                tongtien += cthd.Thanhtien;
            }
            ViewData["tongtien"] = tongtien.ToString("n0");
            return View(lstctHD);
        }
        public IActionResult ThongKeDaDuyet()
        {
            return View();
        }
        public async Task<IActionResult> ThongKeTheoHoaDonDaDuyet()
        {
            var applicationDbContext = _context.HoaDon.Include(m => m.MakhNavigation).Where(h => h.Trangthai == 1);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            var hd = _context.CthoaDon.Include(k => k.MamhNavigation).Where(m => m.Mahd == id);
            return View(await hd.ToListAsync());
        }

    }
}
