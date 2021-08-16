using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Departament.Data.Entitys.Departament;
using Departament.Data.Entitys.User;

namespace Departament.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<User> Logins { get; set; }
    }
}
