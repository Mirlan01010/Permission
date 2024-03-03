using JWTidentityApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTidentityApp.Conextes
{
    public class AuthDbContext:IdentityDbContext
    {
        public AuthDbContext(DbContextOptions options):base(options)
        {
                    
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
