using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StarWarsWebsite.Models
{
    [Table("Questions")]
    public class Questions
    {
        [Key]
        public int QuestionID { get; set; }
        public int? UserID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}