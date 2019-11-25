using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace thehaguetech_community_portal.Models
{ 
    public class ProfileRelationship
    {

        [Key]
        public Profile profileID {get; set;}

        [Key]
        public Profile profileConnectionID {set;get;}

        [Required]
        [Column(TypeName="Date")]
        public DateTime connectionDate { get; set; } 

    }
}