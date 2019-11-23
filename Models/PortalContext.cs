using Microsoft.EntityFrameworkCore;

namespace thehaguetech_community_portal.Models
{
    public class PortalContext: DbContext
    {
        public DbSet<Profile> profiles {set;get;}
            protected override void OnConfiguring(DbContextOptionsBuilder options)=> options.UseSqlite("Data Source=blogging.db");
            

    }
}