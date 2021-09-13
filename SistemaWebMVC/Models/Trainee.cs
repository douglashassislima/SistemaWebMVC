using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMVC.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ser entre {2} e {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [EmailAddress(ErrorMessage = "Entre com um email válido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

        public Department Department { get; set; }
        [Display(Name = "Departamento")]
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
