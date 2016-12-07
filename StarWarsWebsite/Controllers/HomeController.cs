
using StarWarsWebsite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StarWarsWebsite.Models;

//Zac'c comment

namespace StarWarsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private StarWarsContext db = new StarWarsContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Force is stong with these ones...";

            return View();
        }

        public ActionResult FAQ()
        {

            return View();
        }

        public ActionResult Planets()
        {
            return View();
        }

        public ActionResult PlanetInfo(string name)
        {
            ViewBag.PlanetName = name;
            //add specific planet info here and save them to viewbags
            if (name == "Hoth")
            {
                IEnumerable<Planet> planet = db.Database.SqlQuery<Planet>("SELECT * FROM Planet WHERE PlanetID = 1");
                planet.ToList();
                ViewBag.PlanetID = 1;
                ViewBag.ImagePath = "~/Content/Images/Hoth.png";
                return View(planet);
            }
            if (name == "Felucia")
            {
                IEnumerable<Planet> planet = db.Database.SqlQuery<Planet>("SELECT * FROM Planet WHERE PlanetID = 2");
                planet.ToList();
                ViewBag.ImagePath = "~/Content/Images/Felucia.png";
                return View(planet);
            }
            if (name == "Coruscant")
            {
                IEnumerable<Planet> planet = db.Database.SqlQuery<Planet>("SELECT * FROM Planet WHERE PlanetID = 3");
                planet.ToList();
                ViewBag.ImagePath = "~/Content/Images/Coruscant.png";
                return View(planet);
            }
            if (name == "Tatooine")
            {
                IEnumerable<Planet> planet = db.Database.SqlQuery<Planet>("SELECT * FROM Planet WHERE PlanetID = 4");
                planet.ToList();
                ViewBag.ImagePath = "~/Content/Images/Tatooine.png";
                return View(planet);
            }
            if (name == "Dagobah")
            {
                IEnumerable<Planet> planet = db.Database.SqlQuery<Planet>("SELECT * FROM Planet WHERE PlanetID = 5");
                planet.ToList();
                ViewBag.ImagePath = "~/Content/Images/Dagobah.png";
                return View(planet);
            }
            if (name == "Endor")
            {
                IEnumerable<Planet> planet = db.Database.SqlQuery<Planet>("SELECT * FROM Planet WHERE PlanetID = 6");
                planet.ToList();
                ViewBag.ImagePath = "~/Content/Images/Endor.png";
                return View(planet);
            }
            if (name == "Kamino")
            {
                IEnumerable<Planet> planet = db.Database.SqlQuery<Planet>("SELECT * FROM Planet WHERE PlanetID = 7");
                planet.ToList();
                ViewBag.ImagePath = "~/Content/Images/Kamino.png";
                return View(planet);
            }
            if (name == "Death Star")
            {
                return View();
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}