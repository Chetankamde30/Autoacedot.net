using DemoRegAndLoginWithIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DemoRegAndLoginWithIdentity.DTO;

namespace DemoRegAndLoginWithIdentity.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<DemoRegAndLoginWithIdentity.DTO.RoleStore>? RoleStore { get; set; }
    }
}
