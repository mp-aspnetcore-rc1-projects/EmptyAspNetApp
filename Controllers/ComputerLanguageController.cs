using BasicAspApp.Models;
using Microsoft.AspNet.Mvc;
using System.Linq;
using System;
using BasicAspApp.ViewModels;

namespace BasicAspApp.Controllers
{
    public class ComputerLanguageController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public ComputerLanguageController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var computerLanguages = _context.ComputerLanguages.ToList();
            return View(computerLanguages);
        }

        public IActionResult Show(int Id)
        {
            var computerLanguage = _context.ComputerLanguages.Single(cl => cl.Id == Id);
            if (computerLanguage == null)
            {
                return HttpNotFound();
            }
            var snippets = _context.Snippets.Where(sn => sn.ComputerLanguageId == computerLanguage.Id ).ToList();
            return View(new ComputerLanguageShow(computerLanguage, snippets));
        }

        public IActionResult Create()
        {
            var computerLanguage = new ComputerLanguage();
            return View(computerLanguage);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ComputerLanguage computerLanguage)
        {
            if (ModelState.IsValid)
            {
                _context.ComputerLanguages.Add(computerLanguage);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(computerLanguage);
        }
    }
}