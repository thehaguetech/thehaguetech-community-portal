using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Comapny : Profile
    {
        [Key]
        public int companyID {get; set;}

        public string contactPerson {get; set;}

        [Required]
        public string name {set;get;}


    }
}