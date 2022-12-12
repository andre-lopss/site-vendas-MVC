﻿using SiteDeVendasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteDeVendasMVC.Services
{
    public class DepartmentService
    {
        private readonly SiteDeVendasMVCContext _context;

        public DepartmentService(SiteDeVendasMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
