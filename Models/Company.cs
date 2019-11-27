using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace thehaguetech_community_portal.Models
{ 
    public class Company : Profile
    {
     
        public string companyContactPerson {get; set;}

        [Required]
        public string comapnyName {get; set;}

        public string companyWebsite {get; set;}

        public string companyAddress {get; set;}
        
        public string companyRoom {get; set;}

        [Required]
        public string companyType {get; set;}


    }
}