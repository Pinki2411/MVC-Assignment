using FootballLeagueManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballLeagueManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        SportsEntities db = new SportsEntities();
        private object m;

        // GET: Home
        public ActionResult Index()
        {
            var data = db.FootBallLeagues.ToList();
            return View(data);
        }
        public ActionResult Display()
        {
            var d = from  i in  FootBallLeague  where SportsEntities.Status == "Win" select m;
            return View(d);
        }
    }
}