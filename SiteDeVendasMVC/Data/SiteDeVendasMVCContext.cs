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

        public DbSet<SiteDeVendasMVC.Models.Department> Department { get; set; }
    }
}
