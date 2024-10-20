using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CinesUH_3C_2024.Models;

namespace CinesUH_3C_2024.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CinesUH_3C_2024.Models.SalasUH> SalasUH { get; set; } = default!;
    }
}
