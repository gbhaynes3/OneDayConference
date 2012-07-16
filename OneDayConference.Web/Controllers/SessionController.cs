using System;
using System.Web.Mvc;
using OneDayConference.Web.Models;

namespace OneDayConference.Web.Controllers
{
    public class SessionController : Controller
    {
        private SessionRepository _repository;

        public SessionController() : this(new SessionRepository())
        {
        }

        public SessionController(SessionRepository repository)
        {
            _repository = repository;
        }

        //
        // GET: /Session/

        public ActionResult Index()
        {
            var sessions = _repository.All;
            return View(sessions);
        }

        //
        // GET: /Session/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult List(int speakerId)
        {
            var sessions = _repository.FindBySpeakerId(speakerId);

            return View(sessions);
        }

        //
        // GET: /Session/Create

        public ActionResult Create(int speakerId)
        {
            var session = new Session();
            
            return View(session);
        }

        //
        // POST: /Session/Create

        [HttpPost]
        public ActionResult Create(Session session, int speakerId)
        {
            try
            {
                var speaker = _repository.FindSpeakerBySpeakerId(speakerId); 
                session.Speaker = speaker;
                _repository.InsertOrUpdate(session);
                _repository.Save();
                return RedirectToAction("List", new {speakerId = speakerId});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Session/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Session/Edit/5

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
        // GET: /Session/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Session/Delete/5

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