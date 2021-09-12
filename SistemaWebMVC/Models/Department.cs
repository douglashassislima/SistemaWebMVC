using System.Collections.Generic;
namespace SistemaWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();

        public Department ()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
