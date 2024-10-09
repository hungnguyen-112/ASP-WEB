using BaiKiemTra03_03.Data;
using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_03.Controllers
{
    [Area("Admin")]
    public class HopDongController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HopDongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.HopDong = _db.HopDong.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HopDong hopdong)
        {
            if (ModelState.IsValid)
            {
                // thêm thông tin vào bảng theloai
                _db.HopDong.Add(hopdong);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var hopdong = _db.HopDong.Find(id);
            return View(hopdong);
        }
        [HttpPost]
        public IActionResult Edit(HopDong hopdong)
        {
            if (ModelState.IsValid)
            {
                // thêm thông tin vào bảng theloai
                _db.HopDong.Update(hopdong);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var hopdong = _db.HopDong.Find(id);
            return View(hopdong);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var hopdong = _db.HopDong.Find(id);
            if (hopdong == null)
            {
                return NotFound();
            }
            _db.HopDong.Remove(hopdong);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
