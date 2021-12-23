using MP2_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MP2_FinalProject.Controllers
{
    [Authorize(Users = "John@oak.com")]
    public class SecretController : Controller
    {
        private TaskDBContext db = new TaskDBContext();

        // GET: Secret
        [OutputCache(Duration = 2)]
        public ActionResult Index()
        {

            var tasks = from t in db.Tasks
                        orderby t.ID
                        select t;
            return View(tasks);
        }

        // GET: Secret/Details/5
        [OutputCache(Duration = int.MaxValue, VaryByParam = "id")]
        public ActionResult Details(int id)
        {
            var task = db.Tasks.SingleOrDefault(e => e.ID == id);
            return View(task);
        }

        // GET: Secret/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Secret/Create
        [HttpPost]
        public ActionResult Create(TaskViewModel task)
        {
            try
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Secret/Edit/5
        public ActionResult Edit(int id)
        {
            var task = db.Tasks.Single(m => m.ID == id);
            return View(task);
        }

        // POST: Secret/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var task = db.Tasks.Single(m => m.ID == id);
                if (TryUpdateModel(task))
                {
                    //To Do:- database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(task);
            }
            catch
            {
                return View();
            }
        }

        // GET: Secret/Delete/5
        public ActionResult Delete(int id)
        {
            var task = db.Tasks.SingleOrDefault(e => e.ID == id);
            return View(task);
        }

        // POST: Secret/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                TaskViewModel t = db.Tasks.Find(id);
                db.Tasks.Remove(t);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}