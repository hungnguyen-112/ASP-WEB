using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKy(TaiKhoanViewModel model)
        {
            if (model.Username != null && model.Hoten != null && model.Tuoi > 0 && model.Password != null)
            {
                return Content($"Username: {model.Username}, Họ tên: {model.Hoten}, Tuổi: {model.Tuoi}, Password: {model.Password}");
            }
            return View();
        }
    }
}
