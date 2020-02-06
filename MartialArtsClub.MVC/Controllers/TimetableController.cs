using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MartialArtsClub.Data.Models;
using MartialArtsClub.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MartialArtsClub.MVC.Controllers
{
    public class TimetableController : Controller
    {
        private ITimetableDataService service;

        public TimetableController()
        {
            service = new TimetableDataService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Timetable> timetables = (List<Timetable>)service.SelectAll();
            return View(timetables);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Timetable obj)
        {
            if(ModelState.IsValid)
            {
                //check valid state
                service.Insert(obj);
                return RedirectToAction("Index");
            }
            else
            {
                // not valid so redisplay
                return View(obj);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Timetable existing = service.SelectByID(id);
            return View(existing);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult ConfirmEdit(Timetable obj)
        {
            if(ModelState.IsValid)
            {
                // check valid state
                service.Update(obj);
                return RedirectToAction("Index");
            }
            else
            {
                // not valid so redisplay
                return View(obj);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Timetable existing = service.SelectByID(id);
            return View(existing);
        }
    }
}