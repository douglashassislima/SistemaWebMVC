using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaWebMVC.Models;

namespace SistemaWebMVC.Data
{
    public class SistemaWebMVCContext : DbContext
    {
        public SistemaWebMVCContext (DbContextOptions<SistemaWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaWebMVC.Models.Department> Department { get; set; }
    }
}
