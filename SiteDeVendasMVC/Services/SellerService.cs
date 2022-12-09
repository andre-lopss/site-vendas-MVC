using SiteDeVendasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeVendasMVC.Services
{
    public class SellerService
    {
        private readonly SiteDeVendasMVCContext _context;

        public SellerService(SiteDeVendasMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
