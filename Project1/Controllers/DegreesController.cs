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
                ViewBag.Question1 = "How do I apply?";
                ViewBag.Answer1 = "To apply, please complete the online application found at https://marriottschool.byu.edu/apply/bsis/.";
                ViewBag.Question2 = "What GPA do I need to apply?";
                ViewBag.Answer2 = "A minimum 3.0 overall GPA is required to apply, though it does not guarantee acceptance. A minimum 3.0 prerequisite GPA is also required, but again, does not guarantee acceptance.";
                ViewBag.Question3 = "What are the prerequesites for the Information Systems junior core?";
                ViewBag.Answer3 = "The prerequisite classes for the information systems junior core are as follows:" +
                    "\nIS 201 (IS 110 must be taken before or concurrently with IS 201)" +
                    "\nACC 200" +
                    "\nFIN 201" +
                    "\nBUS M 241" +
                    "\nIS 303 (or CS 142)" +
                    "\nIS 201 and IS 303 (CS 142) require a grade of B or better.";
                ViewBag.Question4 = "What should I do if I want to do an internship during a fall/winter semester? Is there a way to defer?";
                ViewBag.Answer4 = "Yes, to defer for an internship, mission, or other reason," +
                    "you must apply for a deferment. Deferment forms are available online at " +
                    "the Marriot School Website</a>."+
                    "Aside from a deferment," +
                    "once accepted into the Marriott School, you must be enrolled in a three-credit " +
                    "hour class for every semester that you are in the program (excluding spring/summer terms).";

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
                ViewBag.Question1 = "";
                ViewBag.Answer1 = "";
                ViewBag.Question2 = "";
                ViewBag.Answer2 = "";
                ViewBag.Question3 = "";
                ViewBag.Answer3 = "";
                ViewBag.Question4 = "";
                ViewBag.Answer4 = "";


                return View("Degree");
            }
            else
            {
                return View();
            }
        }

        public ActionResult ChooseDegree()
    {
        return View("ChooseDegree");
    }
    }
}