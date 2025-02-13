using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title must be at least 3 characters long.");
            }
            if (obj != null && obj.Content.Length < 5)
            {
                ModelState.AddModelError("Content", "Content must be at least 5 characters long.");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);  // Adds the new diary entry to the database
                _db.SaveChanges();  // Saves the changes to the database
                return RedirectToAction("Index");
            }

            return View(obj);

        }
    }
}
