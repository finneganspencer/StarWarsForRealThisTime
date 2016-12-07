using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StarWarsWebsite.Models;

namespace StarWarsWebsite.DAL
{
    public class StarWarsContext : DbContext
    {
        public StarWarsContext() : base("StarWarsContext")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Questions> Question { get; set; }
        public DbSet<Planet> Planets { get; set; }
    }
}