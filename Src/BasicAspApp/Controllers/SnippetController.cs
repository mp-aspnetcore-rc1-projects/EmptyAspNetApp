using System.Linq;
using System;
using Microsoft.AspNet.Mvc;
using BasicAspApp.Models;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;

namespace BasicAspApp.Controllers
{
    public class SnippetController : Controller
    {

        private ApplicationDbContext _context { get; set; }

        public SnippetController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Snippets.Include(s => s.ComputerLanguage).ToList());
        }

        public IActionResult Show(int Id)
        {
            var model = _context.Snippets.Include(s=>s.ComputerLanguage).Single(snippet => snippet.Id == Id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.ComputerLanguageSelectionList = new SelectList(_context.ComputerLanguages.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Snippet snippet)
        {
            if (ModelState.IsValid)
            {
                snippet.CreationDate = DateTime.Now;
                snippet.UpateDate = DateTime.Now;
                _context.Snippets.Add(snippet);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ComputerLanguageSelectionList = new SelectList(_context.ComputerLanguages.ToList(), "Id", "Name");
            return View(snippet);
        }
    }

}
