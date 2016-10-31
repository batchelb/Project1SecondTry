using Project1SecondTry.DAL;
using Project1SecondTry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class DegreeController : Controller
    {
        private Project1Context db = new Project1Context();
        // GET: Degree
        public ActionResult Degree()
        {
            return View();
        }

        public ActionResult Degrees(Project1Context filtercontext,string type) 
        {
 
           
            ViewBag.Type = type;
            ViewBag.Form = "<div class=\"row\"> <div class=\"col-xs-2\">Post any questions here:</div><div class=\"col-xs-3\"><fieldset><div><textarea rows=\"6\" cols=\"50\">Enter Question...</textarea></div></fieldset></div><div class=\"col-xs-1\"><br><br><br><br><br><button>Post</button></div><div class=\"col-xs-2\">Post any answers here:</div><div class=\"col-xs-3\"><fieldset><div><textarea rows=\"6\" cols=\"50\">Enter Answer...</textarea></div></fieldset></div><div class=\"col-xs-1\"><br><br><br><br><br><button>Post</button></div>";
            if(type.Equals("Masters"))
            {
                ViewBag.DegreeName = "Master's In Information Systems Management";
                ViewBag.DegreeCoor = "Dr. Bonnie Anderson";
                ViewBag.Title = "Doctor";
                ViewBag.Office = "776 TNRB";
                ViewBag.PhD = "Information Systems, Carnegie Mellon University, 2001";
                ViewBag.Masters = "MAcc, Information Systems, Brigham Young University, 1995";
                ViewBag.Bachelors = "BS, Accounting, Brigham Young University, 1995";
                ViewBag.Admit = "60";
                ViewBag.Img = Url.Content("../../Content/Bonnie.jpg");

            }

            else if(type.Equals("Bachelors"))
            {
                ViewBag.DegreeName = "Bachelor's in Information Systems";
                ViewBag.DegreeCoor = "Dr. Conan Albrecht";
                ViewBag.Title = "Doctor";
                ViewBag.Office = "780 TNRB";
                ViewBag.PhD = "A university";
                ViewBag.Masters = "A universey";
                ViewBag.Bachelors = "A universey";
                ViewBag.Admit = "120";
                ViewBag.Img = Url.Content("../../Content/ConanAlbrect.jpg");
            }

            return View(db.Responses.ToList());
            }

        [HttpPost]
        public ActionResult Create(int ResponseId, string Response, string QuestionId )
        {
            
            Response response = new Response();
            response.ResponseId = 3;
            response.Responses = "Super";
            response.QuestionId = "1";
            db.Responses.Add(response);
            db.SaveChanges();
            return View("Degree");
        }
    }

    
}