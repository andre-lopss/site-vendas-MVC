using SiteDeVendasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeVendasMVC.Services
{
    public class DepartmentService
    {
        private readonly SiteDeVendasMVCContext _context;

        public DepartmentService(SiteDeVendasMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
