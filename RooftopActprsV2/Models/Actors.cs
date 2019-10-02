using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RooftopActors.Models
{
    public class Actors
    {

        [Key]
        public int actID { get; set; }
        public string actName { get; set; }
        public string actSurname { get; set; }
        //[ForeignKey("ProjectID")]
        //public Project Project { get; set; }

        public IList<Project> Projects { get; set; }            



    }
}