using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicApp.Models;

namespace MusicApp.Controllers
{
    public class HomeController : Controller
    {
        private MusicDBEntities _db = new MusicDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Musics.OrderBy(x=>x.Singer).ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Models.Music musicToCreate)
        {
            if (!ModelState.IsValid)
                return View();

            _db.Musics.Add(musicToCreate);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var movieToEdit = (from m in _db.Musics
                               where m.Id == id
                               select m).First();

            return View(movieToEdit);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Music musicToEdit)
        {
            var originalMusic = (from m in _db.Musics
                                 where m.Id == musicToEdit.Id
                                 select m).First();

            if (!ModelState.IsValid)
                return View(originalMusic);

            _db.Entry(originalMusic).CurrentValues.SetValues(musicToEdit);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Home/Delete/5
        public ActionResult Delete(FormCollection fcNotUsed, int id = 0)
        {
            Models.Music music = _db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            _db.Musics.Remove(music);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
