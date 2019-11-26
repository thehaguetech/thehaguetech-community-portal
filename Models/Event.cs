using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Event
    {
        [Key]
        public int eventID {get; set;}

        [Required]
        public string name {set;get;}

        [Required]
         public string address {set;get;}
                
        [Required]
        public string description {set;get;}

        public string picture {set;get;}

        [Required]
        public int capacity {set; get;}

       [Required]
        public Profile creator {set;get;}

        public Room room {set; get;}

    }
}