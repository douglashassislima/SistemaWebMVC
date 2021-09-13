using Microsoft.EntityFrameworkCore;
using SistemaWebMVC.Data;
using SistemaWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SistemaWebMVCContext _context;

        public DepartmentService(SistemaWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
