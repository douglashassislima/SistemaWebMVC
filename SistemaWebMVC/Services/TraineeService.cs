using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebMVC.Data;
using SistemaWebMVC.Models;

namespace SistemaWebMVC.Services
{
    public class TraineeService
    {
        private readonly SistemaWebMVCContext _context;

        public TraineeService(SistemaWebMVCContext context)
        {
            _context = context;
        }

        public List<Trainee> FindAll()
        {
            return _context.Trainee.ToList();
        }

        public void Insert (Trainee obj)
        {
           
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Trainee FindById(int id)
        {
            return _context.Trainee.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove (int id)
        {
            var obj = _context.Trainee.Find(id);
            _context.Trainee.Remove(obj);
            _context.SaveChanges();
        }
    }
}
