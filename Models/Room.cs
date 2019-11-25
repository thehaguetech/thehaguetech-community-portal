using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Room
    {
        [Key]
        public int roomID {get; set;}

        [Required]
        public string name {set;get;}

        [Required]
        public int number {set;get;}
       
       [Required]
       public int capacity {set;get;}

       [Required]
       public string equipment {set;get;}

    }
}