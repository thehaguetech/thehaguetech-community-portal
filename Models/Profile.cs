using System.Collections.Generic;
namespace thehaguetech_community_portal.Models
{ 
    public class Profile
    {
        public int profileID {get; set;}
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        public string email { get; set; }

        public int memberSince {get; set;}

        public string expertise {get; set;}

        public string picture {set; get;}
    }
}