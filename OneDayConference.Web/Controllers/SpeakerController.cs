using System.Web.Mvc;
using System.Web.Routing;
using OneDayConference.Web.Models;

namespace OneDayConference.Web.Controllers
{
    public class SpeakerController : Controller
    {

         private IRepository<Speaker> _repository;

        public SpeakerController() : this(new SpeakerRepository())
        {
        }

        public SpeakerController(IRepository<Speaker> repository)
        {
            _repository = repository;
        }
        

        //
        // GET: /Speaker/Details/5

        public ActionResult Details(int id)
        {
            var speaker = _repository.Find(id);
            return View(speaker);
        }

        public ActionResult Index()
        {
            var speakers = _repository.All;
            return View(speakers);
        }

        //
        // GET: /Speaker/Register

        public ActionResult Register()
        {
            var speaker = new Speaker();
            return View(speaker);
        } 

        //
        // POST: /Speaker/Create

        [HttpPost]
        public ActionResult Register(Speaker speaker)
        {
            try
            {
                _repository.InsertOrUpdate(speaker);
                _repository.Save();
                return RedirectToAction("Create", "Session", new {speakerId = speaker.Id});
            }
            catch
            {
                return View(speaker);
            }
        }
        
        //
        // GET: /Speaker/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Speaker/Edit/5

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
        // GET: /Speaker/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Speaker/Delete/5

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
