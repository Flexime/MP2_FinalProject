using MP2_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MP2_FinalProject.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private TaskDBContext db = new TaskDBContext();

        // GET: Task
        [OutputCache(Duration = 2)]
        public ActionResult Index()
        {

            var tasks = from t in db.Tasks
                            orderby t.ID
                            select t;
            return View(tasks);
        }
    }
}