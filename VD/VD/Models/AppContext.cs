using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VD.Models.Authorization;

namespace VD.Models
{
    public class AppContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
        }
    }
}
