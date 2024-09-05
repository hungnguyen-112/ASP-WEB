using BaiTap5.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap5.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ngay = "Ngày 04";
            ViewBag.Thang = "Tháng 09";
            ViewData["nam"] = "Năm 2024";
            return View();
        }

        public IActionResult Index2()
        {
            var theloai = new TheLoaiViewModel
            {
                Id=1,
                Name  = "Trinh Thám"
            };
            return View(theloai);
        }
    }
}
