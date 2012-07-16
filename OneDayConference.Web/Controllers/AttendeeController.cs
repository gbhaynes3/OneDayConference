using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneDayConference.Web.Models;

namespace OneDayConference.Web.Controllers
{
    public class AttendeeController : Controller
    {
        private IRepository<Attendee> _repository;

        public AttendeeController(IRepository<Attendee> repository )
        {
            _repository = repository;
        }

        public AttendeeController():this(new AttendeeRepository()){}
        
        //
        // GET: /Attendee/

        public ActionResult Index()
        {
            var attendess = _repository.All;
            return View(attendess);
        }

        //
        // GET: /Attendee/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Attendee/Create

        public ActionResult Create()
        {
            Attendee attendee = new Attendee();
            
            return View(attendee);
        } 

        //
        // POST: /Attendee/Create

        [HttpPost]
        public ActionResult Create(Attendee attendee)
        {
            try
            {
                _repository.InsertOrUpdate(attendee);
                _repository.Save();
                return RedirectToAction("Index", "Session");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Attendee/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Attendee/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Attendee/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Attendee/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
