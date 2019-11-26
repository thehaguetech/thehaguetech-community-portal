using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace thehaguetech_community_portal.Models
{ 
    public class EventAttend
    {


        [Key]
        public int eventAttendID {get; set;}

        [Key]
        public Event eventFKID {get; set;}

        [Key]
        public Profile profileFKID {set;get;}

        [Required]
        [Column(TypeName="Date")]
        public DateTime registrationDate { get; set; } 

    }
}