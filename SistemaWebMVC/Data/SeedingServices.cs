using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebMVC.Models;
using SistemaWebMVC.Models.Enums;

namespace SistemaWebMVC.Data
{
    public class SeedingServices
    {
        private SistemaWebMVCContext _context;

        public SeedingServices(SistemaWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Trainee.Any() ||
                _context.TraineesRecords.Any())
            {
                return; //DB has been seeded (O DB já foi populado, não acontece nada)
            }

            Department d1 = new Department(1, "Back-end");
            Department d2 = new Department(2, "Front-end");
            Department d3 = new Department(3, "Fullstack");
            Department d4 = new Department(4, "UI/UX");

            Trainee t1 = new Trainee (1, "Douglas Henrique de Assis Lima", "douglashenriquedeassis@gmail.com", new DateTime(1998, 8, 5), d1);
            Trainee t2 = new Trainee(2, "Isaias Roberto", "isaiasroberto@gmail.com", new DateTime(1994, 7, 26), d2);
            Trainee t3 = new Trainee(3, "Pedro Fernandes", "fernandes@gmail.com", new DateTime(1992, 2, 25), d3);
            Trainee t4 = new Trainee(4, "Gabriel Carfe", "gabrielcarfe@gmail.com", new DateTime(2000,2,25), d4);

            TraineesRecords r1 = new TraineesRecords (1, new DateTime(2018, 08, 25), TraineeStatus.MetaCompleted, t1);
            TraineesRecords r2 = new TraineesRecords(2, new DateTime(2021, 08, 4), TraineeStatus.MetaCompleted, t3);
            TraineesRecords r3 = new TraineesRecords(3, new DateTime(2021, 08, 13), TraineeStatus.MetaCompleted, t4);
            TraineesRecords r4 = new TraineesRecords(4, new DateTime(2021, 08, 1), TraineeStatus.MetaCompleted, t1);
            TraineesRecords r5 = new TraineesRecords(5, new DateTime(2021, 08, 21), TraineeStatus.MetaCompleted, t3);
            TraineesRecords r6 = new TraineesRecords(6, new DateTime(2021, 08, 15),  TraineeStatus.MetaCompleted, t1);
            TraineesRecords r7 = new TraineesRecords(7, new DateTime(2021, 08, 28), TraineeStatus.MetaCompleted, t2);
            TraineesRecords r8 = new TraineesRecords(8, new DateTime(2021, 08, 11), TraineeStatus.MetaCompleted, t4);
            TraineesRecords r9 = new TraineesRecords(9, new DateTime(2021, 08, 14), TraineeStatus.MetaCompleted, t1);
            TraineesRecords r10 = new TraineesRecords(10, new DateTime(2021, 09, 1), TraineeStatus.MetaCompleted, t4);
            TraineesRecords r11 = new TraineesRecords(11, new DateTime(2021, 09, 9), TraineeStatus.MetaCompleted, t2);
            TraineesRecords r12 = new TraineesRecords(12, new DateTime(2021, 09, 5), TraineeStatus.MetaCompleted, t3);
            TraineesRecords r13 = new TraineesRecords(13, new DateTime(2021, 09, 10), TraineeStatus.MetaCompleted, t4);
            TraineesRecords r14 = new TraineesRecords(14, new DateTime(2021, 09, 4), TraineeStatus.MetaCompleted, t2);
            TraineesRecords r15 = new TraineesRecords(15, new DateTime(2021, 09, 12), TraineeStatus.MetaCompleted, t1);
            TraineesRecords r16 = new TraineesRecords(16, new DateTime(2021, 08, 5), TraineeStatus.MetaCompleted, t2);
            TraineesRecords r17 = new TraineesRecords(17, new DateTime(2021, 09, 1), TraineeStatus.MetaCompleted, t1);
            TraineesRecords r18 = new TraineesRecords(18, new DateTime(2021, 09, 24), TraineeStatus.MetaCompleted, t3);
           

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Trainee.AddRange(t1, t2, t3, t4);

            _context.TraineesRecords.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18);

            _context.SaveChanges();

        }

    }

}

