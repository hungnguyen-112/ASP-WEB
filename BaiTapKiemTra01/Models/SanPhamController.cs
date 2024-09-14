using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Models
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Điện thoại iPhone 14 Pro Max",
                GiaBan = 33990000,
                AnhMoTa = "/images/tải_xuống-removebg-preview.png"
            };

            return View(sanpham);
        }
    }
}
