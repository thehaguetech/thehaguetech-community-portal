using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class ExpertiseProfile
    {
        [Key]
        public int expertiseProfileID {get; set;}

        [Required]
        public Profile profileFKID {get; set;}

        [Required]
        public Expertise expertiseFKID {get; set;}

    }
}