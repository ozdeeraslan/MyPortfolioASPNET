using Microsoft.AspNetCore.Mvc;
using MyPortfolioAspNet.DAL.Context;
using MyPortfolioAspNet.DAL.Entities;

namespace MyPortfolioAspNet.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext _db = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = _db.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _db.Experiences.Add(experience);
            _db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _db.Experiences.Find(id);
            _db.Experiences.Remove(value);
            _db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _db.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _db.Experiences.Update(experience);
            _db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
