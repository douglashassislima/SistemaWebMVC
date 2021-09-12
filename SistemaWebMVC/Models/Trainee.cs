using System;
using System.Collections.Generic;

namespace SistemaWebMVC.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<TraineesRecords> Trainees { get; set; } = new List<TraineesRecords>();

        public Trainee()
        {
        }

        public Trainee(int id, string name, string email, DateTime nascimento, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Nascimento = nascimento;
            Department = department;
        }

        public void AddTrainees(TraineesRecords sr)
        {
            Trainees.Add(sr);
        }

        public void RemoveTrainees(TraineesRecords sr)
        {
            Trainees.Remove(sr);
        }
    }
}
