using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thehaguetech_community_portal.Models
{ 
    public class Profile
    {
        [Key]
        public int profileID {get; set;}

        [Required]
        public string firstName {get; set;}

        [Required]
        public string lastName {get; set;}
        
        [Required]
        public string email {get; set;}
        
        [Required]
        [Column(TypeName="Date")]
        public DateTime memberSince {get; set;}

        public string picture {get; set;}

    }
}