
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Zac'c comment

namespace StarWarsWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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
                ViewBag.ImagePath = "~/Content/Images/Hoth.png";
                ViewBag.Region = "Outer Rim Territories";
                ViewBag.Sector = "Anoat";
                ViewBag.System = "Hoth";
                ViewBag.Moons = "3";
                ViewBag.Class = "Terrestrial";
                ViewBag.PrimaryTerrain = "Frozen ice plains, glaciers";
                ViewBag.Species = "Hothian, Human";
                ViewBag.Languages = "-";
                ViewBag.Population = "Fewer than 10";
                ViewBag.MajorCities = "-";
                ViewBag.Affiliation = "Alliance to Restore the Republic";
            }
            if (name == "Felucia")
            {
                ViewBag.ImagePath = "~/Content/Images/Felucia.png";
                ViewBag.Region = "Outer Rim Territories";
                ViewBag.Sector = "-";
                ViewBag.System = "Felucia";
                ViewBag.Moons = "8";
                ViewBag.Class = "Terrestrial";
                ViewBag.PrimaryTerrain = "Jungles";
                ViewBag.Species = "Felucian, Jungle-rancor, tee-,muss";
                ViewBag.Languages = "-";
                ViewBag.Population = "-";
                ViewBag.MajorCities = "-";
                ViewBag.Affiliation = "Confederacy of Independent Systems, Galatic Empire";
            }
            if (name == "Coruscant")
            {
                ViewBag.ImagePath = "~/Content/Images/Coruscant.png";
                ViewBag.Region = "Core Worlds";
                ViewBag.Sector = "Coruscant subsector";
                ViewBag.System = "-";
                ViewBag.Moons = "4";
                ViewBag.Class = "Terrestrial";
                ViewBag.PrimaryTerrain = "Ecumenopolis";
                ViewBag.Species = "Human, many others";
                ViewBag.Languages = "Galatic Basic, Thousands others";
                ViewBag.Population = "Over 1 trillion";
                ViewBag.MajorCities = "Galactic City";
                ViewBag.Affiliation = "Old Repulic, Galatic Repulics, Jedi Order, Sith, Galatic Empire, New Repulic";
            }
            if (name == "Tatooine")
            {
                ViewBag.ImagePath = "~/Content/Images/Tatooine.png";
                ViewBag.Region = "Outer Rim Territories";
                ViewBag.Sector = "Arkansis";
                ViewBag.System = "Tatoo";
                ViewBag.Moons = "3";
                ViewBag.Class = "Terrestrial";
                ViewBag.PrimaryTerrain = "Deserts, canyons, rocky bluffs";
                ViewBag.Species = "Jawa, Tusken Raider, Aqualish, Bith, Dug, Human, Hutt, Rodian, Talz, Toydarian, Twi'lek, Weequay";
                ViewBag.Languages = "Bocce, Galatic Basic, Huttese, Jawaese, Tusken";
                ViewBag.Population = "200,000";
                ViewBag.MajorCities = "Anchorhead, Bestine, Freetown, Mos Doba, Mos Eisley, Mos Espa, Tosche Station";
                ViewBag.Affiliation = "Hutt Clan, Galactic Empire";
            }
            if (name == "Dagobah")
            {
                ViewBag.ImagePath = "~/Content/Images/Dagobah.png";
                ViewBag.Region = "Outer Rim Territories";
                ViewBag.Sector = "Sluis";
                ViewBag.System = "Dagobah";
                ViewBag.Moons = "0";
                ViewBag.Class = "-";
                ViewBag.PrimaryTerrain = "Swamp, bogs, wetlands";
                ViewBag.Species = "Yoda's species";
                ViewBag.Languages = "-";
                ViewBag.Population = "At least 1";
                ViewBag.MajorCities = "-";
                ViewBag.Affiliation = "Sith, Galactic Republic";
            }
            if (name == "Endor")
            {
                ViewBag.ImagePath = "~/Content/Images/Endor.png";
                ViewBag.Region = "Outer Rim Territories";
                ViewBag.Sector = "Moddell";
                ViewBag.System = "Endor";
                ViewBag.Moons = "-";
                ViewBag.Class = "-";
                ViewBag.PrimaryTerrain = "Forests, savannas, mountains";
                ViewBag.Species = "Dulok, Ewoks, Yuzzum, Gorax";
                ViewBag.Languages = "Ewok Dialect";
                ViewBag.Population = "30,000,000";
                ViewBag.MajorCities = "Bright Tree Village";
                ViewBag.Affiliation = "Galactic Empire, Alliance to Restore the Republic";
            }
            if (name == "Kamino")
            {
                ViewBag.ImagePath = "~/Content/Images/Kamino.png";
                ViewBag.Region = "Outer Rim Territories";
                ViewBag.Sector = "Abrion";
                ViewBag.System = "Kamino";
                ViewBag.Moons = "3";
                ViewBag.Class = "-";
                ViewBag.PrimaryTerrain = "Aquatic";
                ViewBag.Species = "Kaminoans";
                ViewBag.Languages = "Galatic Basic, Kaminoan";
                ViewBag.Population = "1,000,000,000";
                ViewBag.MajorCities = "Tipoca City";
                ViewBag.Affiliation = "Sith, Galactic Republic";
            }
            if (name == "Death Star")
            {

            }


            return View();
        }
    }
}