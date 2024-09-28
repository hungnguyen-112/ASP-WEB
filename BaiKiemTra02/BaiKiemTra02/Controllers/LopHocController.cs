using BaiKiemTra02.Data;
using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaiKiemTra02.Controllers
{
     public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LopHocController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            var lophoc = _db.lopHoc.ToList();
            ViewBag.LopHoc = lophoc;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                // thêm thông tin vào bảng lophoc
                _db.lopHoc.Add(lophoc);
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
            var lophoc = _db.lopHoc.Find(id);
            return View(lophoc);
        }
        [HttpPost]
        public IActionResult Edit(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
        
                _db.lopHoc.Update(lophoc);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var lophoc = _db.lopHoc.Find(id);
            if (lophoc == null)
            {
                return NotFound();
            }
            _db.lopHoc.Remove(lophoc);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
