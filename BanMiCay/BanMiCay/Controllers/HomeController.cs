﻿using BanMiCay.Data;
using BanMiCay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BanMiCay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<KhachHang> _passwordHasher;
        private readonly IPasswordHasher<NhanVien> _nvpasswordHasher;
        public HomeController(ApplicationDbContext context, IPasswordHasher<KhachHang> passwordHasher, IPasswordHasher<NhanVien> nvpasswordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _nvpasswordHasher = nvpasswordHasher;
        }
        // GET: Home/Details/5
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

        public async Task<IActionResult> Index()
        {
            GetInfo();
            var applicationDbContext = _context.MatHang.Include(m => m.MadmNavigation).Where(h => h.Daxoa == 0);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Index1(int id)
        {
            GetInfo();
            var applicationDbContext = _context.MatHang.Include(m => m.MadmNavigation).Where(h => h.Daxoa == 0 && h.Madm == id);
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("shopcart");
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Lưu danh sách CartItem trong giỏ hàng vào session
        void SaveCartSession(List<CartItem> list)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(list);
            session.SetString("shopcart", jsoncart);
        }

        // Xóa session giỏ hàng
        void ClearCart()
        {
            GetInfo();
            var session = HttpContext.Session;
            session.Remove("shopcart");
        }

        // Cho hàng vào giỏ
        public async Task<IActionResult> AddToCart(int id)
        {
            var MatHang = await _context.MatHang
                .FirstOrDefaultAsync(m => m.Mamh == id);
            if (MatHang == null)
            {
                return NotFound("Sản phẩm không tồn tại");
            }
            var cart = GetCartItems();
            var item = cart.Find(p => p.MatHang.Mamh == id);
            if (item != null)
            {
                item.SoLuong++;
            }
            else
            {
                cart.Add(new CartItem() { MatHang = MatHang, SoLuong = 1 });
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }

        public IActionResult UpdateItem(int id, int quantity)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.MatHang.Mamh == id);
            if (item != null)
            {
                item.SoLuong = quantity;
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }

        public IActionResult RemoveItem(int id)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.MatHang.Mamh == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }


        // Chuyển đến view xem giỏ hàng
        public IActionResult ViewCart()
        {
            GetInfo();
            return View(GetCartItems());
        }


        public IActionResult CheckOut()
        {
            if (HttpContext.Session.GetString("khachhang") == "" || HttpContext.Session.GetString("khachhang") == null)
            {
                GetInfo();
                return View(GetCartItems());

            }
            else
            {
                int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
                List<DiaChi> lstDiaChi = _context.DiaChi.Where(d => d.Makh == makh && d.Daxoa == 0).ToList();
                ViewBag.diachi = lstDiaChi;
                GetInfo();
                return View(GetCartItems());
            }
        }

        public void GetInfo()
        {
            ViewData["SoLuongGioHang"] = GetCartItems().Count;
            ViewBag.danhmuc = _context.DanhMuc.ToList();

            if (HttpContext.Session.GetString("khachhang") != "" || HttpContext.Session.GetString("khachhang") != null)
            {
                ViewBag.khachhang = _context.KhachHang.FirstOrDefault(k => k.Makh.ToString() == HttpContext.Session.GetString("khachhang"));
            }
        }
        public IActionResult Login()
        {
            GetInfo();
            return View();
        }

        public IActionResult Register()
        {
            GetInfo();
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string matkhau)
        {
            KhachHang kh = _context.KhachHang.FirstOrDefault(k => k.Email == email && k.Matkhau != null && k.Daxoa == 0);
            var nv = _context.NhanVien.FirstOrDefault(n => n.Email == email);
            if (kh != null && matkhau != null && _passwordHasher.VerifyHashedPassword(kh, kh.Matkhau, matkhau) == PasswordVerificationResult.Success)
            {
                HttpContext.Session.SetString("khachhang", kh.Makh.ToString());
                return RedirectToAction(nameof(Customer));
            }
            else if(nv!=null && _nvpasswordHasher.VerifyHashedPassword(nv,nv.Matkhau,matkhau) == PasswordVerificationResult.Success)
            {
                HttpContext.Session.SetString("nhanvien", email);
                return RedirectToAction("Index","Main");
            }

            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public async Task<IActionResult> Register(string email, string matkhau, string hoten, string dienthoai, string diachicuthe, string phuongxa, string quanhuyen, string tinhthanh)
        {
            GetInfo();
            // kiểm tra email đã đăng kí tài khoản chưa
            var tmp = _context.KhachHang.FirstOrDefault(k => k.Matkhau != null && k.Email == email);
            if (tmp != null)
            {
                // khách hàng đã có tài khoản
                return RedirectToAction(nameof(Register));
            }
            else
            {
                // lưu khách hàng
                KhachHang kh = new KhachHang();
                kh.Ten = hoten;
                kh.Dienthoai = dienthoai;
                kh.Email = email;
                kh.Matkhau = _passwordHasher.HashPassword(kh, matkhau);
                kh.Daxoa = 0;
                _context.Add(kh);
                await _context.SaveChangesAsync();

                // lưu địa chỉ
                DiaChi dc = new DiaChi();
                dc.Diachi1 = diachicuthe;
                dc.Phuongxa = phuongxa;
                dc.Quanhuyen = quanhuyen;
                dc.Tinhthanh = tinhthanh;
                dc.Makh = kh.Makh;
                dc.Macdinh = 1;
                dc.Daxoa = 0;
                _context.Add(dc);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Login));
            }
        }

        public IActionResult Customer()
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            var lstDiaChi = _context.DiaChi.Where(d => d.Makh == makh && d.Daxoa == 0);
            GetInfo();
            return View(lstDiaChi);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("khachhang", "");
            GetInfo();
            return RedirectToAction(nameof(Index));
        }

        // GET
        public IActionResult AddAddress()
        {
            GetInfo();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAddress(string diachicuthe, string phuongxa, string quanhuyen, string tinhthanh)
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            DiaChi dc = new DiaChi();
            dc.Makh = makh;
            dc.Diachi1 = diachicuthe;
            dc.Phuongxa = phuongxa;
            dc.Quanhuyen = quanhuyen;
            dc.Tinhthanh = tinhthanh;
            dc.Daxoa = 0;
            dc.Macdinh = 0;
            _context.Add(dc);
            await _context.SaveChangesAsync();
            GetInfo();
            return RedirectToAction(nameof(Customer));
        }

        // GET
        public IActionResult EditAccount()
        {
            GetInfo();
            return View();
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> EditAccount(string email, string matkhau, string hoten, string dienthoai)
        {
            // kiểm tra email đã đk tài khoản chưa && không phải khách hàng hiện tại && mật khẩu không bỏ trống
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            KhachHang khCheck = _context.KhachHang.FirstOrDefault(k => k.Email == email && k.Makh != makh && k.Matkhau != null);
            if (khCheck != null)
            {
                GetInfo();
                return RedirectToAction(nameof(EditAccount));
            }

            KhachHang kh = _context.KhachHang.FirstOrDefault(k => k.Makh == makh);
            kh.Email = email;
            kh.Ten = hoten;
            kh.Dienthoai = dienthoai;
            if (matkhau != null)
            {
                kh.Matkhau = _passwordHasher.HashPassword(kh, matkhau);
            }
            _context.Update(kh);
            await _context.SaveChangesAsync();

            GetInfo();
            return RedirectToAction(nameof(Customer));
        }

        public async Task<IActionResult> SetDefaultAddress(int id)
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            DiaChi dc1 = _context.DiaChi.FirstOrDefault(d => d.Makh == makh && d.Macdinh == 1);
            dc1.Macdinh = 0;
            _context.Update(dc1);

            DiaChi dc2 = _context.DiaChi.FirstOrDefault(d => d.Madc == id);
            dc2.Macdinh = 1;
            _context.Update(dc2);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Customer));
        }

        public async Task<IActionResult> DeleteAddress(int id)
        {
            DiaChi dc = _context.DiaChi.FirstOrDefault(d => d.Madc == id);
            dc.Daxoa = 1;
            _context.Update(dc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Customer));
        }

        public async Task<IActionResult> CreateBill(string hoten, string email, string dienthoai, string diachicuthe, string phuongxa, string quanhuyen, string tinhthanh, int madiachi)
        {
            KhachHang kh;
            DiaChi dc;

            if (HttpContext.Session.GetString("khachhang") == "" || HttpContext.Session.GetString("khachhang") == null) // chưa đăng nhập
            {
                // lưu khách hàng
                kh = new KhachHang();
                kh.Ten = hoten;
                kh.Email = email;
                kh.Dienthoai = dienthoai;
                _context.Add(kh);
                await _context.SaveChangesAsync();

                // lưu địa chỉ
                dc = new DiaChi();
                dc.Diachi1 = diachicuthe;
                dc.Phuongxa = phuongxa;
                dc.Quanhuyen = quanhuyen;
                dc.Tinhthanh = tinhthanh;
                dc.Makh = kh.Makh;
                dc.Macdinh = 1;
                dc.Daxoa = 0;
                _context.Add(dc);
                await _context.SaveChangesAsync();
            }
            else // đã đăng nhập
            {
                int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
                kh = _context.KhachHang.FirstOrDefault(k => k.Makh == makh);
                dc = _context.DiaChi.FirstOrDefault(d => d.Madc == madiachi);
            }

            // lưu hóa đơn 
            HoaDon hd = new HoaDon();
            hd.Makh = kh.Makh;
            hd.Ngay = DateTime.Now;
            hd.Madc = dc.Madc;
            hd.Trangthai = 0; //0: chưa duyệt, 1: đã duyệt, 2: hủy
            _context.Add(hd);
            await _context.SaveChangesAsync();

            // lưu chi tiết hóa đơn
            var cart = GetCartItems();
            int thanhtien;
            int tongthanhtien = 0;
            foreach (CartItem i in cart)
            {
                CthoaDon ct = new CthoaDon();
                ct.Mahd = hd.Mahd;
                ct.Mamh = i.MatHang.Mamh;
                ct.Soluong = (short)i.SoLuong;
                ct.Dongia = i.MatHang.Giaban;
                thanhtien = i.SoLuong * i.MatHang.Giaban;
                ct.Thanhtien = thanhtien;
                tongthanhtien += thanhtien;
                _context.Add(ct);
            }
            await _context.SaveChangesAsync();

            hd.Tongtien = tongthanhtien;
            _context.Update(hd);
            await _context.SaveChangesAsync();

            // xóa giỏ hàng
            ClearCart();

            GetInfo();
            return View(hd);
        }

        public async Task<IActionResult> Search(string SearchKey)
        {
            var lstHang = await _context.MatHang.Include(m => m.MadmNavigation)
                            .Where(k => k.Ten.Contains(SearchKey) && k.Daxoa == 0).ToListAsync();
            GetInfo();
            return View(lstHang);
        }


        public IActionResult DonHangChuaDuyet()
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            var lstdonhang = _context.HoaDon.Include(h => h.MadcNavigation).Where(d => d.Makh == makh && d.Trangthai == 0);
            GetInfo();
            return View(lstdonhang);
        }

        public IActionResult DonHangDaDuyet()
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            var lstdonhang = _context.HoaDon.Include(h => h.MadcNavigation).Where(d => d.Makh == makh && d.Trangthai == 1);
            GetInfo();
            return View(lstdonhang);
        }

        public IActionResult DonHangDaHuy()
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            var lstdonhang = _context.HoaDon.Include(h => h.MadcNavigation).Where(d => d.Makh == makh && d.Trangthai == 2);
            GetInfo();
            return View(lstdonhang);
        }

        public IActionResult ChiTietHoaDon(int id)
        {
            ViewBag.hoadon = _context.HoaDon.Include(h => h.MadcNavigation).FirstOrDefault(b => b.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(c => c.Mahd == id);
            GetInfo();
            return View(lstCTHoaDon);
        }

        public async Task<IActionResult> HuyDonHang(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 2;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DonHangDaHuy));
        }

    }
}
