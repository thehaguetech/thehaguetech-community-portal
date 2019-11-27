using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Member : Profile
    {
        public Company company {get; set;}
       
        [Required]
        public bool employee {get; set;}

        [Required]
        public bool CEO {get; set;}


    }
}