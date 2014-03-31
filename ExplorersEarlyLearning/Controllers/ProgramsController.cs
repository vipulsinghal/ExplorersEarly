using ExplorersEarlyLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExplorersEarlyLearning.Controllers
{
    public class ProgramsController : Controller
    {
        //
        // GET: /Programs/

        public ActionResult Index()
        {
            return View(new ViewModelBase() { NavCurrentIndex = 3 });
        }

        public ActionResult AnEmergent()
        {
            return View(new ViewModelBase() { NavCurrentIndex = 3 });
        }
    }
}
