using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebMVC.Data;
using SistemaWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using SistemaWebMVC.Services.Exceptions;

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

        public void Insert(Trainee obj)
        {

            _context.Add(obj);
            _context.SaveChanges();
        }

        public Trainee FindById(int id)
        {
            return _context.Trainee.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Trainee.Find(id);
            _context.Trainee.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Trainee obj)
        {
            if (!_context.Trainee.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
    

