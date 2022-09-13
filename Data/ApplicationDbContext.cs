using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VisitorManagementSystem.Models;

namespace VisitorManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VisitorManagementSystem.Models.StaffNames>? StaffNames { get; set; }
        public DbSet<VisitorManagementSystem.Models.Visitors>? Visitors { get; set; }
    }
}