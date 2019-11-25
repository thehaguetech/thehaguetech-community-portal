using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thehaguetech_community_portal.Models
{ 
    public class RoomBooking
    {
        [Key]
        public Room roomID {get; set;}

        [Key]
        public Profile profileID {get; set;}

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