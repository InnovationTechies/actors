using System.ComponentModel.DataAnnotations;

namespace RooftopActors.Models
{
    
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectStartDate { get; set; }
        public string ProjectEndDate { get; set; }

    }
}