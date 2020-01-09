using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Event
    {
        [Key]
        public int eventID {get; set;}

        [Required]
        public string name {get; set;}

        [Required]
         public string address {get; set;}
                
        [Required]
        public string description {get; set;}

        public string picture {get; set;}

        [Required]
        public int capacity {get; set;}

       [Required]
        public Profile creator {get; set;}

        public Room room {get; set;}

    }
}