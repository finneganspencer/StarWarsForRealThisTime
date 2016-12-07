using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StarWarsWebsite.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}