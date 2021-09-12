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
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
