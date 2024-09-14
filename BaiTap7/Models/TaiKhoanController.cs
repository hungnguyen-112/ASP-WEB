using Microsoft.AspNetCore.Mvc;

namespace BaiTap7.Models
{
    public class modelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKy(TaiKhoanViewModel model)
        {
            if (model != null && model.Password != null && model.Password.Length > 0)
            {
                model.Password = model.Password + "_da_ma_hoa";
            }
            return View(model);
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
