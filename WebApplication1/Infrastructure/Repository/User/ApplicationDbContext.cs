using Gladiatus.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gladiatus.Infrastructure.Repository.User
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> Users { get; set; }

    }
}