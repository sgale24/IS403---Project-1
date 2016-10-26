using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class DegreesController : Controller
    {
        // GET: Degrees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Degree(String degree)
        {
            if (degree == "BSIS")
            {
                ViewBag.DegreeName = "Information Systems";
                ViewBag.Coordinator = "Dr. Albrecht";
                ViewBag.ProfTitle = "Professor of Information Systems";
                ViewBag.Office = "780 TNRB";
                ViewBag.PhD = "Doctor of Philosophy, Management Information Systems, University of Arizona, 2000";
                ViewBag.Masters = "Masters of Accountancy, School of Accountancy and Information Systems, Brigham Young University, 1997";
                ViewBag.Bachelors = "Bachelors of Science, School of Accountancy and Information Systems, Brigham Young University, 1997";
                ViewBag.Picture = "albrecht.jpeg";

                return View("Degree");
            }
            if (degree == "MISM")
            {
                ViewBag.DegreeName = "Masters of Information Systems";
                ViewBag.Coordinator = "Dr. Anderson";
                ViewBag.ProfTitle = "Associate Professor of Information Systems";
                ViewBag.Office = "776 TNRB";
                ViewBag.PhD = "PhD, Information Systems, Carnegie Mellon University, 2001";
                ViewBag.Masters = "MPhil, Public Policy, Carnegie Mellon University, 2000";
                ViewBag.Bachelors = "BS, Accounting, Brigham Young University, 1995";
                ViewBag.Picture = "anderson.jpg";

                return View("Degree");
            }
            else
            {
                return View();
            }
        }
    }
}