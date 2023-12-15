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
    public class MainController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainController(ApplicationDbContext context)
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
            var lstHD = _context.HoaDon.Include(m => m.MakhNavigation).Where(d => d.Ngay >= Ngaybatdau && d.Ngay <= Ngayketthuc && d.Trangthai == 1);
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

        public IActionResult ThongKeKhachHang()
        {
            GetInfo();
            return View();
        }

        public IActionResult XemThongKeKhachHang(string emailkhachhang)
        {
            var lstHoaDon = _context.HoaDon.Include(m => m.MakhNavigation)
                            .Where(h => h.MakhNavigation.Email == emailkhachhang && h.MakhNavigation.Matkhau != null && h.Trangthai == 1);
            int tongtien = 0;
            foreach (HoaDon hd in lstHoaDon)
            {
                tongtien += hd.Tongtien;
            }
            ViewBag.ttkhachhang = _context.KhachHang.FirstOrDefault(k => k.Email == emailkhachhang && k.Matkhau != null);
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstHoaDon);
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
            var lstctHD = _context.CthoaDon.Include(m => m.MamhNavigation).Where(j => j.Mamh == id);
            int tongtien = 0;
            foreach (CthoaDon cthd in lstctHD)
            {
                tongtien += cthd.Thanhtien;
            }
            ViewData["tongtien"] = tongtien.ToString("n0");
            return View(lstctHD);
        }

        
        public async Task<IActionResult> Details(int id)
        {
            var hd = _context.CthoaDon.Include(k => k.MamhNavigation).Where(m => m.Mahd == id);
            return View(await hd.ToListAsync());
        }

        public IActionResult HoaDonChuaDuyet()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 0);

            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult HoaDonDaDuyet()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 1);

            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult HoaDonDaHuy()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 2);

            GetInfo();
            return View(lstHoaDon);
        }



        public IActionResult ChiTietHoaDonChuaDuyet(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public IActionResult ChiTietHoaDonDaDuyet(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public IActionResult ChiTietHoaDonDaHuy(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public async Task<IActionResult> DuyetDonHang(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 1;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }

        public async Task<IActionResult> HuyDonHang(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 2;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }

    }
}
