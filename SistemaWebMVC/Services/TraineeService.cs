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

        public async Task<List<Trainee>> FindAllAsync()
        {
            return await _context.Trainee.ToListAsync();
        }

        public async Task InsertAsync(Trainee obj)
        {

            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Trainee> FindByIdAsync(int id)
        {
            return await _context.Trainee.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync (int id)
        {
            try
            {
                var obj = await _context.Trainee.FindAsync(id);
                _context.Trainee.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegrityException("Trainee em treinamento");
            }
        }

        public async Task UpdateAsync(Trainee obj)
        {
            bool hasAny= await _context.Trainee.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
               await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
    

