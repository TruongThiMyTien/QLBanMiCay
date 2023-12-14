using BanMiCay.Data;
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
        public HomeController(ApplicationDbContext context, IPasswordHasher<KhachHang> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
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
            var applicationDbContext = _context.MatHang.Include(m => m.MadmNavigation);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Index1(int id)
        {
            GetInfo();
            var applicationDbContext = _context.MatHang.Where(p => p.Madm == id).Include(m => m.MadmNavigation);
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
            GetInfo();
            return View(GetCartItems());

        }

        public void GetInfo()
        {
            ViewData["SoLuongGioHang"] = GetCartItems().Count;
            ViewBag.danhmuc = _context.DanhMuc.ToList();
            if (HttpContext.Session.GetString("khachhang") != "")
            {
                ViewBag.khachhang = _context.KhachHang.FirstOrDefault(k => k.Email == HttpContext.Session.GetString("khachhang"));
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
            KhachHang kh = _context.KhachHang.FirstOrDefault(k => k.Email == email);
            if (kh != null && _passwordHasher.VerifyHashedPassword(kh, kh.Matkhau, matkhau) == PasswordVerificationResult.Success)
            {
                HttpContext.Session.SetString("khachhang", kh.Email);
                return RedirectToAction(nameof(Customer));
            }
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public IActionResult Register(string email, string matkhau, string hoten, string dienthoai)
        {
            KhachHang kh = new KhachHang();
            kh.Email = email;
            kh.Matkhau = _passwordHasher.HashPassword(kh, matkhau);
            kh.Ten = hoten;
            kh.Dienthoai = dienthoai;
            _context.Add(kh);
            _context.SaveChanges();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Customer()
        {
            GetInfo();
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("khachhang", "");
            GetInfo();
            return RedirectToAction(nameof(Index));
        }
    }
}
