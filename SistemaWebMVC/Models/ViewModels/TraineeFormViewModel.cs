using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebMVC.Models.ViewModels
{
    public class TraineeFormViewModel
    {
        public Trainee Trainee { get; set; }
        public ICollection <Department> Departments { get; set; }
    }
}
