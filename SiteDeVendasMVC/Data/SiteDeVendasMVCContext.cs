using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteDeVendasMVC.Models
{
    public class SiteDeVendasMVCContext : DbContext
    {
        public SiteDeVendasMVCContext (DbContextOptions<SiteDeVendasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
