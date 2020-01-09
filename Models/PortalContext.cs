using Microsoft.EntityFrameworkCore;

namespace thehaguetech_community_portal.Models
{
    public class PortalContext: DbContext
    {
        public DbSet<Profile> profiles {get; set;}
        public DbSet<SocialLink> socialLinks {get; set;}
        public DbSet<Company> companies {get; set;}
        public DbSet<Room> rooms {get; set;}
        public DbSet<Event> events {get; set;}
        public DbSet<ExpertiseProfile> expertiseProfiles {get; set;}
        public DbSet<ProfileRelationship> profileRelationships {get; set;}
        public DbSet<RoomBooking> roombookings {get; set;}
        public DbSet<EventAttend> eventAttends {get; set;}


            protected override void OnConfiguring(DbContextOptionsBuilder options)=> options.UseSqlite("Data Source=Portal.db");
            

    }
}