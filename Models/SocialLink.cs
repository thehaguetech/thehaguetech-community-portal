using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class SocialLink
    {
        [Key]
        public int linkID {get; set;}

        [Key]
        public Profile profileID {get; set;}

        [Required]
        public string name {set;get;}



    }
}