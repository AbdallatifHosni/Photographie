using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Photography.Models;

namespace Photography.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Client>? Client { get; set; }
        public DbSet<Photographer>? Photographer { get; set; }
        public DbSet<Work>? Work { get; set; }

    }
}