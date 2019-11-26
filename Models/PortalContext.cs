using Microsoft.EntityFrameworkCore;

namespace thehaguetech_community_portal.Models
{
    public class PortalContext: DbContext
    {
        public DbSet<Profile> profiles {set;get;}
        public DbSet<SocialLink> socialLinks {set;get;}
        public DbSet<Comapny> companies {set;get;}
        public DbSet<Room> rooms {set;get;}
        public DbSet<Event> events {set;get;}
        public DbSet<ProfileRelationship> profileRelationships {set; get;}
        public DbSet<RoomBooking> roombookings {set; get;}
        public DbSet<EventAttend> eventAttends {set;get;}


            protected override void OnConfiguring(DbContextOptionsBuilder options)=> options.UseSqlite("Data Source=blogging.db");
            

    }
}