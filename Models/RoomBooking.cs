using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thehaguetech_community_portal.Models
{ 
    public class RoomBooking
    {

        [Key]
        public int roomBookingID {get; set;}

        [Key, Required]
        public Room roomFKID {get; set;}

        [Key, Required]
        public Profile profileFKID {get; set;}

        [Required]
        [Column(TypeName="Date")]
        public DateTime timeStart { get; set; } 
        
        [Required]
        [Column(TypeName="Date")]
        public DateTime timeEnd { get; set; } 

        [Required]
        [Column(TypeName="Date")]
        public DateTime registrationDate { get; set; } 


    }
}