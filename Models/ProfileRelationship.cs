using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace thehaguetech_community_portal.Models
{ 
    public class ProfileRelationship
    {
        [Key]
        public int ProfileRelationShipID {get; set;}

        [Key, Required]
        public Profile profileFKID {get; set;}

        [Key, Required]
        public Profile profileConnectionFKID {set;get;}

        [Required]
        [Column(TypeName="Date")]
        public DateTime connectionDate { get; set; } 

    }
}