using FootBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootBall.Controllers
{
    public class ClubsController : Controller
    {
        // GET: Clubs
        public ActionResult Index()
        {
            var clubs = new Clubs() { Name = "Manchester United" };
            return View(clubs);
        }
    }
}