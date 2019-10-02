using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace RooftopActorsV3.Models
{
    public class Actors
    {

        [Key]
        public int actID { get; set; }
        public string actName { get; set; }
        public string actSurname { get; set; }
        //public Image Image { get; set; }
        public byte[] actImage { get; set; }


        //[ForeignKey("ProjectID")]
        //public Project Project { get; set; }

        public IList<Project> Projects { get; set; }            



    }
}