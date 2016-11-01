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
                ViewBag.Answer1 = "To apply, please complete the online application.";
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
                    "the Marriot School Website."+
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
                ViewBag.Question1 = "What can I do to increase my chances of getting into the MISM?";
                ViewBag.Answer1 = "There are a variety of things taken into consideration when deciding who is accepted to the MISM." +
                    "We look at grades, professionalism and overall attitude.  Get the best grades you can but know that that is not" +
                    " the only thing that goes into admittance.  Work well with your team, be professional with your professors," +
                    " and above all have fun and love what you do!";
                ViewBag.Question2 = "What is the cost of the MISM?";
                ViewBag.Answer2 = "Ideally, integrated MISM/BSIS students will pay graduate tuition during" +
                    " their last two semesters at BYU. Students admitted as regular graduate students pay "+
                    "graduate tuition throughout their entire time in the program.";
                ViewBag.Question3 = "What optional tracks are available?";
                ViewBag.Answer3 = "Business Analytics and Intelligence Track, Security and Forensic Track, Developement Track and Pre-PhD Track";
                ViewBag.Question4 = "What is the deadline for applications?";
                ViewBag.Answer4 = "Deadline for application for all applicants (U.S. and international," +
                    " including all graduating/graduated BSIS students): March 1 of the desired entrance year."+
                    " Admission is granted for the Fall semester only. Admission decisions are usually available "+
                    "near the middle of May of the application year.";


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

        [HttpPost]
        public ActionResult QA(FormCollection collection)
        {
            // This will clear whatever form items have been populated
            ModelState.Clear();

            return View("Degree");
        }
    }
}