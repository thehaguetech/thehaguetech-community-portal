using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Room
    {
        [Key]
        public int roomID {get; set;}

        [Required]
        public string name {get; set;}

        [Required]
        public int number {get; set;}
       
       [Required]
       public int capacity {get; set;}

       [Required]
       public string equipment {get; set;}

    }
}