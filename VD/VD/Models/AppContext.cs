using Microsoft.EntityFrameworkCore;
using VD.Models.Authorization;
using VD.Models.BasicItm;

namespace VD.Models
{
    public class AppContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Item> Items { get; set; }
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
        }
    }
}
