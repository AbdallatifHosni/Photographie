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
        public DbSet<Photography.Models.Client> Client { get; set; }
        public DbSet<Photography.Models.Photographer> Photographer { get; set; }
        public DbSet<Photography.Models.Work> Work { get; set; }

    }
}