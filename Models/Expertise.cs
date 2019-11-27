using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Expertise
    {
        [Key]
        public int expertiseID {get; set;}

        [Required]
        public string name {get; set;}

    }
}