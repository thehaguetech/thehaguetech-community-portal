using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Member : Profile
    {
        public string teamID {get; set;}
        public string phone {get; set;}
       
    }
}