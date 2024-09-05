using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Hoàng Hải hưng";
            ViewBag.MSSV = "1822040013";
            ViewBag.Nam = "Nguyễn Hoàng Hải Hưng - 2024";
            return View();
        }
    }
}
