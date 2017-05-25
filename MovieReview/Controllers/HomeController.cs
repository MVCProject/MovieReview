using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieReview.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeUserAccessLevel(UserRole ="Admin")]
        // GET: About
        public ActionResult About()
        {
            return View();
        }

        //GET: Contact
        [AuthorizeUserAccessLevel(UserRole = "Manager")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}