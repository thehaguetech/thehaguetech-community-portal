using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Comapny : Profile
    {
     
        public string contactPerson {get; set;}

        [Required]
        public string name {set;get;}


    }
}