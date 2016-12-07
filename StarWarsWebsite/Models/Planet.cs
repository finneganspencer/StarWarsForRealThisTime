using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StarWarsWebsite.Models
{
    [Table("Planet")]
    public class Planet
    {
        [Key]
        public int PlanetID { get; set; }
        public string PlanetName { get; set; }
        public string Region { get; set; }
        public string Sector { get; set; }
        public string System { get; set; }
        public int? Moons { get; set; }
        public string Class { get; set; }
        public string Terrain { get; set; }
        public string Species { get; set; }
        public string PrimaryLanguage { get; set; }
        public string Population { get; set; }
        public string CapitalCity { get; set; }
        public string Government { get; set; }
    }
}