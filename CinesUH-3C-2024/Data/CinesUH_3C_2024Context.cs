using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CinesUH_3C_2024.Models;

namespace CinesUH_3C_2024.Data
{
    public class CinesUH_3C_2024Context : DbContext
    {
        public CinesUH_3C_2024Context (DbContextOptions<CinesUH_3C_2024Context> options)
            : base(options)
        {
        }

        public DbSet<CinesUH_3C_2024.Models.SalasUH> SalasUH { get; set; } = default!;
    }
}
