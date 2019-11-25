using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace thehaguetech_community_portal.Models
{ 
    public class EventAttend
    {

        [Key]
        public Event eventID {get; set;}

        [Key]
        public Profile profileID {set;get;}

        [Required]
        [Column(TypeName="Date")]
        public DateTime registrationDate { get; set; } 

    }
}